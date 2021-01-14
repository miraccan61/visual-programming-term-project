using System;
using System.Windows.Forms;
using EntityLayer;
using LogicLayer;

namespace LibraryManagement.Student
{
    public partial class StudentSigninUI : Form
    {
        public StudentSigninUI()
        {
            InitializeComponent();
        }
        private void StudentSignIn_Click(object sender, EventArgs e)
        {
            EntityStudent ent = new EntityStudent();
            ent.StudentUserName = TxtStudentUserName.Text;
            ent.StudentName = TxtStudentName.Text;
            ent.StudentLastName = TxtStudentLastName.Text;
            ent.Password = TxtStudentPassword1.Text;
            ent.Repassword = TxtStudentPassword2.Text;
            if (ent.Password == ent.Repassword)
            {
                LogicStudent.LLStudentSignIn(ent);
                MessageBox.Show("Başarılı Bir Şekilde Kayıt Oldunuz Giriş Yapabilirsiniz");
                TxtStudentUserName.Text="";
                TxtStudentName.Text="";
                TxtStudentLastName.Text="";
                TxtStudentPassword1.Text="";
                TxtStudentPassword2.Text="";
            }
            else
            {
                MessageBox.Show("Şifreleriniz Uyuşmuyor Lütfen Kontrol Ediniz");
            }
        }
    }
}
