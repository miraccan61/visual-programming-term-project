using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;


namespace LibraryManagement.Personal.CRUD
{
    public partial class StudentInformationUI : Form
    {
        public StudentInformationUI()
        {
            InitializeComponent();
            TxtStudentDebt.Text = "0";

        }

        private void BtnStudentAdd_Click(object sender, EventArgs e)
        {
            // Textbox'lardan gelen veriler kontrol ediliyor boş veri varsa uyarı mesajı bırakıyoruz çünkü veritabanında boş verilerin bulunmasını istemiyoruz
            // EntityStudent üzerinde oluşturduğumuz nesnemize gerekli atamaları yaptıktan sonra
            // Nesnelerimizin kontrolünü yapmak üzere Mantıksal Katmana verilerimizi gönderiyoruz.
            if (TxtStudentName.Text != "" && TxtStudentLastName.Text != "" && TxtStudentPassword1.Text != "" &&
                TxtStudentPassword2.Text != "" && TxtStudentUserName.Text != "" && CmbStudentGender.Text != "" && TxtStudentDebt.Text != "")
            {
                EntityStudent ent = new EntityStudent();
                ent.StudentName = TxtStudentName.Text;
                ent.StudentLastName = TxtStudentLastName.Text;
                ent.Password = TxtStudentPassword1.Text;
                ent.Repassword = TxtStudentPassword2.Text;
                ent.StudentUserName = TxtStudentUserName.Text;
                ent.StudentGender = CmbStudentGender.Text;
                ent.StudentDebt = int.Parse(TxtStudentDebt.Text);
                LogicPersonal.LLStudentSave(ent);
                MessageBox.Show("Öğrenci Başarılı Bir Şekilde Kaydedildi");
                TxtStudentId.Text = "";
                TxtStudentName.Text = "";
                TxtStudentLastName.Text = "";
                TxtStudentPassword1.Text = "";
                TxtStudentPassword2.Text = "";
                TxtStudentUserName.Text = "";
                CmbStudentGender.Text = "";
                TxtStudentDebt.Text = "";
                // Data Gride verileri getirmek için EntityStudent class'ından StudentList adında generic bir liste oluşturuyoruz ve Mantıksal Katman(Logic Layer)
                // üzerinden LLStudentList methodu Veri Erişim Katmanına Erişerek (DAL) gerekli SQL sorgusu ile öğrenciler hakkında tüm bilgiler getirilir.
                List<EntityStudent> StudentList = LogicStudent.LLStudentList();
                // DataSource veri kaynağı olarak bir Generic List almaktadır

                dataGridView1.DataSource = StudentList;
                dataGridView1.Columns["Password"].Visible = false;
                dataGridView1.Columns["Repassword"].Visible = false;

            }
            else
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }
        }

        private void BtnStudentUpdate_Click(object sender, EventArgs e)
        {
            // Textbox'lardan gelen veriler kontrol ediliyor boş veri varsa uyarı mesajı bırakıyoruz çünkü veritabanında boş verilerin bulunmasını istemiyoruz
            // EntityStudent üzerinde oluşturduğumuz nesnemize gerekli atamaları yaptıktan sonra
            // Nesnelerimizin kontrolünü yapmak üzere Mantıksal Katmana verilerimizi gönderiyoruz.
            if (TxtStudentName.Text != "" && TxtStudentLastName.Text != "" && TxtStudentPassword1.Text != "" &&
              TxtStudentPassword2.Text != "" && TxtStudentUserName.Text != "" && CmbStudentGender.Text != "" && TxtStudentDebt.Text != "")
            {
                EntityStudent ent = new EntityStudent();
                ent.StudentId = int.Parse(TxtStudentId.Text);
                ent.StudentName = TxtStudentName.Text;
                ent.StudentLastName = TxtStudentLastName.Text;
                ent.Password = TxtStudentPassword1.Text;
                ent.Repassword = TxtStudentPassword2.Text;
                ent.StudentUserName = TxtStudentUserName.Text;
                ent.StudentGender = CmbStudentGender.Text;
                ent.StudentDebt = int.Parse(TxtStudentDebt.Text);
                LogicPersonal.LLStudentUpdate(ent);
                MessageBox.Show("Güncelleme Başarılı Bir Şekilde Kaydedildi");
                TxtStudentName.Text = "";
                TxtStudentLastName.Text = "";
                TxtStudentPassword1.Text = "";
                TxtStudentPassword2.Text = "";
                TxtStudentUserName.Text = "";
                CmbStudentGender.Text = "";
                TxtStudentDebt.Text = "";

            }
            else
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }
        }

        private void BtnStudentDelete_Click(object sender, EventArgs e)
        {
            // Sadece ID kontrol etmemiz yeterli VeriTabanından Kayıtlar Nesneyi eşsiz yapan bir özelliği üzerinden silinirler 
            // ID her öğrencinin benzersiz sahip olduğu bir özelliktir
            if (TxtStudentId.Text != "")
            {
                EntityStudent ent = new EntityStudent();
                ent.StudentId = int.Parse(TxtStudentId.Text);
                LogicPersonal.LLStudentDelete(ent.StudentId);
                MessageBox.Show("Güncelleme Başarılı Bir Şekilde Silindi");
                TxtStudentName.Text = "";
                TxtStudentLastName.Text = "";
                TxtStudentPassword1.Text = "";
                TxtStudentPassword2.Text = "";
                TxtStudentUserName.Text = "";
                CmbStudentGender.Text = "";
                TxtStudentDebt.Text = "";

            }
            else
            {
                MessageBox.Show("Id ALanını Boş Bırakmayınız");
            }
        }

        private void StudentList_Click(object sender, EventArgs e)
        {
            // Data Gride verileri getirmek için EntityStudent class'ından StudentList adında generic bir liste oluşturuyoruz ve Mantıksal Katman(Logic Layer)
            // üzerinden LLStudentList methodu Veri Erişim Katmanına Erişerek (DAL) gerekli SQL sorgusu ile öğrenciler hakkında tüm bilgiler getirilir.
            List<EntityStudent> StudentList = LogicStudent.LLStudentList();
            // DataSource veri kaynağı olarak bir Generic List almaktadır

            dataGridView1.DataSource = StudentList;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["Repassword"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtStudentId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtStudentName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtStudentLastName.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtStudentDebt.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            CmbStudentGender.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtStudentUserName.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
