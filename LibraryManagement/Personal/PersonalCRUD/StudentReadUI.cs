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
    public partial class StudentReadUI : Form
    {
        public StudentReadUI()
        {
            InitializeComponent();
        }
        int ogrenciCounter = 0;
        private void BtnStudentList_Click(object sender, EventArgs e)
        {
            ogrenciCounter += 1;
            if (ogrenciCounter < 2)
            {
                // ComboBox'a verileri getirmek için EntityStudent class'ından StudentList adında generic bir liste oluşturuyoruz ve Mantıksal Katman(Logic Layer)
                // üzerinden LLStudentList methodu Veri Erişim Katmanına Erişerek (DAL) gerekli SQL sorgusu ile öğrenciler hakkında tüm bilgiler getirilir.
                // foreach ile gelen generic listi tek tek dönerek Combobox'ın add methodu ile ComboBox'a kaydediyoruz.
                List<EntityStudent> StudentList = LogicStudent.LLStudentList();
                foreach (var item in StudentList)
                {
                    comboBox1.Items.Add(item.StudentName);
                }
            }
            else
            {
                MessageBox.Show("Lütfen 1 Defa Tıklayınız");
            }

        }
        int bookCounter = 0;

        private void BtnBookList_Click(object sender, EventArgs e)
        {
            bookCounter += 1;
            if (bookCounter < 2)
            {
                // ComboBox'a verileri getirmek için EntityBook class'ından BookList adında generic bir liste oluşturuyoruz ve Mantıksal Katman(Logic Layer)
                // üzerinden LLBookList methodu Veri Erişim Katmanına Erişerek (DAL) gerekli SQL sorgusu ile kitaplar hakkında tüm bilgiler getirilir.
                // foreach ile gelen generic listi tek tek dönerek Combobox'ın add methodu ile ComboBox'a kaydediyoruz.
                List<EntityBook> BookList = LogicBook.LLBookList();
                foreach (var item in BookList)
                {
                    comboBox2.Items.Add(item.bookName);
                }
            }
            else
            {
                MessageBox.Show("Lütfen 1 Defa Tıklayınız");
            }

        }

        private void BtnGiveBook_Click(object sender, EventArgs e)
        {
            // Burada öğrencinin okuduğu kitaplar nesnesini üretiyoruz 
            StudentReadInfo studentread = new StudentReadInfo();
            // Üretilen nesnenin hangi öğrenci olduğunu Comboboxtan gelen veriyi StudentList içinde bulup seçtirilir
            studentread.StudentId = DALStudent.StudentList().FirstOrDefault(n => n.StudentName == comboBox1.SelectedItem.ToString());
            // Üretilen nesnenin hangi kitap olduğunu Comboboxtan gelen veriyi BookList içinde bulup seçtirilir
            studentread.BookId = DALBook.BookList().FirstOrDefault(n => n.bookName == comboBox2.SelectedItem.ToString());
            // Öğrencinin okuduğu kitaplar nesnesi üzerinde bulunan kitapın alınma tarihine DateTimePickerdan gelen değeri atanır
            studentread.TakenDate = dateTimePicker1.Value.Date.ToString();
            // Entity katmanında TakenDate String olarak tutulduğu için gerekli tip dönüşüm işlemleri yapılır
            DateTime DueDate = Convert.ToDateTime(studentread.TakenDate);
            // DueDate kitabın teslim edilme tarihini teslim eder bunu DatetimePickerden gelen tarihe 15gün ekleyerek elde edilir.
            DueDate = DueDate.AddDays(15);
            // Entity'miz String olduğu için tekrar tip dönüşümü yapılır
            studentread.GivenDate = DueDate.ToString();
            // Entitymizin Kitabın verilip verilmediğini isGiven değişkeni üzerinde saklanır
            // Kitap verildiği taktirde isGiven true olur.
            studentread.isGiven = true;
            // Gerekli mantıksal işlemler yapılması için LLStudentBookSave methoduna gönderilir.
            LogicStudentRead.LLStudentBookSave(studentread);
            MessageBox.Show("Kitap Verildi");
            // Verilen kitapın alınıp alınmadığını tutan isBookAvailable özelliği ->Busy olarak değiştirilir.
            studentread.BookId.isBookAvailable = "Busy";
            // Kitabın durumunu güncellemek için LLStudentBookUpdate methoduna gönderilir
            LogicStudentRead.LLStudentBookUpdate(studentread.BookId);
            MessageBox.Show("Kitap Durumu Güncellendi");
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! BURAYA SON KEZ BAK !!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void BtnTakeBook_Click(object sender, EventArgs e)
        {
            // Burada öğrencinin okuduğu kitaplar nesnesini üretiyoruz 
            StudentReadInfo studentread = new StudentReadInfo();
            // Üretilen nesnenin hangi öğrenci olduğunu Comboboxtan gelen veriyi StudentList içinde bulup seçtirilir
            studentread.StudentId = DALStudent.StudentList().FirstOrDefault(n => n.StudentName == comboBox1.SelectedItem.ToString());
            // Üretilen nesnenin hangi kitap olduğunu Comboboxtan gelen veriyi BookList içinde bulup seçtirilir
            studentread.BookId = DALBook.BookList().FirstOrDefault(n => n.bookName == comboBox2.SelectedItem.ToString());
            DateTime date = DateTime.Now;
            var shortDate = date.ToString("yyyy-MM-dd");
            studentread.GivenDate = shortDate.ToString();            
            studentread.BookId.isBookAvailable = "Available";
            LogicStudentRead.LLStudentBookUpdate(studentread.BookId);
            MessageBox.Show("Kitap Durumu Güncellendi");
        }
    }
}
