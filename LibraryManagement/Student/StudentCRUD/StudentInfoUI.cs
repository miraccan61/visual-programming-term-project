using System;
using System.Windows.Forms;
using EntityLayer;
using LogicLayer;

namespace LibraryManagement.Student.StudentCRUD
{
    public partial class StudentInfoUI : Form
    {
        // Formlar arası entity aktarımları için aktarılmak istenen entity formda bir nesnesi üretilir 
        // Gelen entity formda üretilen entity'e eşitlenir bu şekilde formda her yerde bu veriler kullanılabilir.
        private EntityStudent student;
        public StudentInfoUI(EntityStudent student)
        {
            InitializeComponent();
            this.student = student;
            //Texbotlar veritabanından gelen kayıtlar ile doldurulur
            TxtName.Text = this.student.StudentName;
            TxtLastName.Text = this.student.StudentLastName;
            TxtUserName.Text = this.student.StudentUserName;
        }
        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            this.student.StudentName = TxtName.Text;
            this.student.StudentLastName = TxtLastName.Text;
            this.student.StudentUserName = TxtUserName.Text;
            this.student.Password = TxtPassword1.Text;
            this.student.Repassword = TxtPassword2.Text;
            LogicStudent.LLStudentUpdate(student);
            MessageBox.Show("Güncelleme Başarılı");
            TxtName.Text = "";
            TxtLastName.Text = "";
            TxtUserName.Text = "";
            TxtPassword1.Text = "";
            TxtPassword2.Text = "";
        }
    }
}
