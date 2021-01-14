using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace LibraryManagement.Student.StudentCRUD
{
    public partial class StudentBookUI : Form
    {
        // Formlar arası entity aktarımları için aktarılmak istenen entity formda bir nesnesi üretilir 
        // Gelen entity formda üretilen entity'e eşitlenir bu şekilde formda her yerde bu veriler kullanılabilir.
        private EntityStudent student;
        public StudentBookUI(EntityStudent student)
        {
            InitializeComponent();
            this.student = student;
        }
        int bookCounter = 0;
        private void BtnGetBooks_Click(object sender, EventArgs e)
        {
            bookCounter += 1;
            if (bookCounter < 2)
            {
                List<EntityBook> bookList = LogicBook.LLBookList();
                foreach (var item in bookList)
                {
                    cmbBookName.Items.Add(item.bookName);
                }
            }
            else
            {
                MessageBox.Show("Lütfen 1 Kez Tıklayınız");
            }
                   
        }

        private void BtnTakeBook_Click(object sender, EventArgs e)
        {
            StudentReadInfo readInfo = new StudentReadInfo();
            readInfo.StudentId = this.student;
            readInfo.BookId = DALBook.BookList().FirstOrDefault(n => n.bookName == cmbBookName.SelectedItem.ToString());
            readInfo.TakenDate = dateTimePicker1.Value.Date.ToString();
            DateTime d2 = Convert.ToDateTime(readInfo.TakenDate);
            d2=d2.AddDays(15);
            readInfo.GivenDate = d2.ToString();
            LogicStudentRead.LLStudentBookSave(readInfo);
            MessageBox.Show("Kitap Alındı");
            readInfo.BookId.isBookAvailable = "Busy";
            LogicStudentRead.LLStudentBookUpdate(readInfo.BookId);
            MessageBox.Show("Kitap Durumu Güncellendi");
        }
     
        private void BtnReleaseBook_Click(object sender, EventArgs e)
        {
            StudentReadInfo readInfo = new StudentReadInfo();
            readInfo.StudentId = this.student;
            readInfo.BookId = DALBook.BookList().FirstOrDefault(n => n.bookName == cmbBookName.SelectedItem.ToString());
            readInfo.TakenDate = dateTimePicker1.Value.Date.ToString();
            DateTime d2 = Convert.ToDateTime(readInfo.TakenDate);
            d2 = d2.AddDays(15);
            readInfo.GivenDate = d2.ToString();
            readInfo.BookId.isBookAvailable = "Available";
            LogicStudentRead.LLStudentBookUpdate(readInfo.BookId);
            MessageBox.Show("Kitap Teslim Edildi Güncellendi");

        }
    }
}
