using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LibraryManagement.Student.StudentCRUD;

namespace LibraryManagement.Student
{
    public partial class StudentMain : Form
    {
        // Formlar arası entity aktarımları için aktarılmak istenen entity formda bir nesnesi üretilir 
        // Gelen entity formda üretilen entity'e eşitlenir bu şekilde formda her yerde bu veriler kullanılabilir.
        private EntityStudent student;

        public StudentMain(EntityStudent student)
        {
            InitializeComponent();
            label2.Text = student.StudentName;
            label3.Text = student.StudentLastName;
            this.student = student;
        }   

        private void BtnBookOperation_Click(object sender, EventArgs e)
        {

            StudentBookUI formbook = new StudentBookUI(student);
            formbook.Show();

        }

        private void StudentMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnStudentRead_Click(object sender, EventArgs e)
        {
            StudentBookUI formbook = new StudentBookUI(student);
            formbook.Show();
        }

        private void BtnListBooks_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            StudentReadInfo studentread = new StudentReadInfo();
            List<StudentReadInfo> degerler = DALStudentRead.StudentReadList().Where(n => n.StudentId.StudentName == student.StudentName).ToList();

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Book Name";
            dataGridView1.Columns[2].Name = "Taken Date";
            dataGridView1.Columns[3].Name = "Given Date";
            dataGridView1.Columns[4].Name = "Is Given";
            dataGridView1.Columns[5].Name = "Geçen Süre";
            dataGridView1.Columns[6].Name = "Borç";
            foreach (var item in degerler)
            {
                int Gecensüre = int.Parse(Convert.ToInt32((DateTime.Now - Convert.ToDateTime(item.TakenDate)).TotalDays).ToString());
                int borç = 0;
                //borç = int.Parse(Convert.ToInt32((DateTime.Now - Convert.ToDateTime(item.GivenDate)).TotalDays).ToString());
                if(Convert.ToDateTime(item.TakenDate).AddDays(15)< Convert.ToDateTime(item.GivenDate)){

                    double a = (Convert.ToDateTime(item.GivenDate) - Convert.ToDateTime(item.TakenDate).AddDays(15)).TotalDays;
                    borç = (int)a;
                }
                int i = dataGridView1.Rows.Add(item.StudentId.StudentName, item.BookId.bookName, item.TakenDate, item.GivenDate, item.isGiven, Gecensüre, borç);
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

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            StudentInfoUI form = new StudentInfoUI(student);
            form.Show();
        }
    }
}
