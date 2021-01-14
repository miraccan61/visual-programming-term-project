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

namespace LibraryManagement.Personal.PersonalCRUD
{
    public partial class StudenReadDataGrid : Form
    {

        public StudenReadDataGrid()
        {
            InitializeComponent();
        }
        int counterOgrenci = 0;
        private void BtnList_Click(object sender, EventArgs e)
        {
            counterOgrenci += 1;
            if (counterOgrenci < 2)
            {
                // BomboBox'a verileri getirmek için EntityStudent class'ından StudentList adında generic bir liste oluşturuyoruz ve Mantıksal Katman(Logic Layer)
                // üzerinden LLStudentListesi methodu Veri Erişim Katmanına Erişerek (DAL) gerekli SQL sorgusu ile öğrenciler hakkında tüm bilgiler getirilir.
                // sadece ismini getirmek için foreach ile gelen nesneleri dönerken nesnenin sahip olduğu StudentName değişkenini Combobox'a ekliyoruz
                List<EntityStudent> StudentList = LogicStudent.LLStudentList();
                foreach (var item in StudentList)
                {
                    comboBox1.Items.Add(item.StudentName);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Sadece 1 Defa Tıklayınız");
            }
           
        }

        private void BtnListBook_Click(object sender, EventArgs e)
        {
            // StudentReadInfo Öğrencilerin okuduğu kitapları tutan bir varlıktır.
            StudentReadInfo studentread = new StudentReadInfo();
            // Yazılan LİNQ sorgusu StudentReadListesi üzerinde StudentName'i bizim Combobox'tan seçtiğimiz isme eşit olanları getiriyoruz
            // getirilen degerler generic list üzerinde daha sonra kullanmak için tutuyoruz
            List<StudentReadInfo> degerler = DALStudentRead.StudentReadList().Where(n => n.StudentId.StudentName == comboBox1.SelectedItem.ToString()).ToList();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            // Datagridin kaç tane alanı olacağını gösterir => |   |   |   |   |
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Book Name";
            dataGridView1.Columns[2].Name = "Taken Date";
            dataGridView1.Columns[3].Name = "Given Date";
            dataGridView1.Columns[4].Name = "Is Given";
            dataGridView1.Columns[5].Name = "Geçen Süre";
            foreach (var item in degerler)
            {
                //Gecen Süre bize kitabı aldığımız günden sonra kaç gün geçtiğini veriyor
                int Gecensüre = int.Parse(Convert.ToInt32((DateTime.Now - Convert.ToDateTime(item.TakenDate)).TotalDays).ToString());
                int i = dataGridView1.Rows.Add(item.StudentId.StudentName, item.BookId.bookName, item.TakenDate, item.GivenDate, item.isGiven, Gecensüre);
                if (Gecensüre >= 13 && Gecensüre < 15)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
                else
                {
                    if (item.isGiven)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;

                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
