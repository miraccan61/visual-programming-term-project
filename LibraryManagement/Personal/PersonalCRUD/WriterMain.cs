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
using LibraryManagement.Personal;

namespace LibraryManagement.Writer
{
    public partial class WriterMain : Form
    {
        public WriterMain()
        {
            InitializeComponent();
        }

        private void BtnWriterAdd_Click(object sender, EventArgs e)
        {
            // Textbox'lardan gelen veriler kontrol ediliyor boş veri varsa uyarı mesajı bırakıyoruz çünkü veritabanında boş verilerin bulunmasını istemiyoruz
            // EntityWriter üzerinde oluşturduğumuz nesnemize gerekli atamaları yaptıktan sonra
            // Nesnelerimizin kontrolünü yapmak üzere Mantıksal Katmana verilerimizi gönderiyoruz.
            if (TxtWriterName.Text != "" && TxtWriterLastName.Text != "" && TxtWriterBirthDate.Text != "" && CmbGender.Text != "")
            {
                EntityWriter entity = new EntityWriter();
                entity.writerName = TxtWriterName.Text;
                entity.writerLastName = TxtWriterLastName.Text;
                entity.writerBirth = TxtWriterBirthDate.Text;
                entity.writerDeath = TxtWriterDeathDate.Text;
                entity.writerGender = CmbGender.Text;
                LogicWriter.LLWriterSave(entity);
                MessageBox.Show("Yazar Kaydı Başarılı Bir Şekilde Eklendi");
                TxtWriterName.Text = "";
                TxtWriterLastName.Text = "";
                TxtWriterBirthDate.Text = "";
                TxtWriterDeathDate.Text = "";
                CmbGender.Text = "";
            }
            else
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }
        }

        private void BtnWriterUpdate_Click(object sender, EventArgs e)
        {
            // Textbox'lardan gelen veriler kontrol ediliyor boş veri varsa uyarı mesajı bırakıyoruz çünkü veritabanında boş verilerin bulunmasını istemiyoruz
            // EntityWriter üzerinde oluşturduğumuz nesnemize gerekli atamaları yaptıktan sonra
            // Nesnelerimizin kontrolünü yapmak üzere Mantıksal Katmana verilerimizi gönderiyoruz.
            if (TxtWriterName.Text != "" && TxtWriterLastName.Text != "" && TxtWriterBirthDate.Text != "" && CmbGender.Text != "")
            {
                EntityWriter entity = new EntityWriter();
                entity.writerId = int.Parse(TxtWriterId.Text);
                entity.writerName = TxtWriterName.Text;
                entity.writerLastName = TxtWriterLastName.Text;
                entity.writerBirth = TxtWriterBirthDate.Text;
                entity.writerDeath = TxtWriterDeathDate.Text;
                entity.writerGender = CmbGender.Text;
                LogicWriter.LLWriterUpdate(entity);
                MessageBox.Show("Yazar Kaydı Başarılı Bir Şekilde Güncellendi");
                TxtWriterId.Text = "";
                TxtWriterName.Text = "";
                TxtWriterLastName.Text = "";
                TxtWriterBirthDate.Text = "";
                TxtWriterDeathDate.Text = "";
                CmbGender.Text = "";
            }
            else
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }
        }

        private void BtnWriterDelete_Click(object sender, EventArgs e)
        {
            // Sadece ID kontrol etmemiz yeterli VeriTabanından Kayıtlar Nesneyi eşsiz yapan bir özelliği üzerinden silinirler 
            // ID her yazarın benzersiz sahip olduğu bir özelliktir
            if (TxtWriterId.Text != "")
            {
                EntityWriter entity = new EntityWriter();
                entity.writerId = int.Parse(TxtWriterId.Text);
                LogicWriter.LLWriterDelete(entity.writerId);
                MessageBox.Show("Yazar Kaydı Başarılı Bir Şekilde Silindi");
                TxtWriterId.Text = "";
                TxtWriterName.Text = "";
                TxtWriterLastName.Text = "";
                TxtWriterBirthDate.Text = "";
                TxtWriterDeathDate.Text = "";
                CmbGender.Text = "";
            }
            else
            {
                MessageBox.Show("Id ALanını Boş Bırakmayınız");
            }
        }

        private void BtnWriterList_Click(object sender, EventArgs e)
        {
            // Data Gride verileri getirmek için EntityWriter class'ından WriterList adında generic bir liste oluşturuyoruz ve Mantıksal Katman(Logic Layer)
            // üzerinden LLWriterList methodu Veri Erişim Katmanına Erişerek (DAL) gerekli SQL sorgusu ile yazarlar hakkında tüm bilgiler getirilir.
            List<EntityWriter> WriterList = LogicWriter.LLWriterList();
            // DataSource veri kaynağı olarak bir Generic List almaktadır
            dataGridView1.DataSource = WriterList;
        }

        // Hücrelere Tıklayınca Textboxların dolmasını sağlar
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtWriterId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtWriterName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtWriterLastName.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtWriterBirthDate.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtWriterDeathDate.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbGender.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

    }
}
