using LibraryManagement.Personal;
using LibraryManagement.Student;
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

namespace LibraryManagement
{
    public partial class LibraryHome : Form
    {
        public LibraryHome()
        {
            InitializeComponent();
            // Test Dataları CTRL k u kombinasyonu ile yorum satırı açılabilir
            //TxtPersonalUserName.Text = "mirac";
            //TxtPersonalPassword.Text = "123";
            //TxtPersonalPassword2.Text = "123";
            //TxtStudentUserName.Text = "miraccan00";
            //TxtStudentPassword1.Text = "1234";
            //TxtStudentPassword2.Text = "1234";
        }

        private void PerRegisterBtn_Click(object sender, EventArgs e)
        {
            PersonelRegisterUI form = new PersonelRegisterUI();
            form.Show();
            //register Button Directive for register form
        }

        private void PerLoginBtn_Click(object sender, EventArgs e)
        {
            // Personel Nesnesi Üreterek gerekli atamaları yapıyoruz
            // Önce Mantıksal Katmanda gelen veriler doğru formatta gelmiş mi kontrol etmek üzere logic katmana gönderiyoruz
            EntityPersonal ent = new EntityPersonal();
            ent.PersonelUserName = TxtPersonalUserName.Text;
            ent.PersonelPassword = TxtPersonalPassword.Text;
            ent.PersonelRepassword = TxtPersonalPassword2.Text;
            if (TxtPersonalPassword.Text == TxtPersonalPassword2.Text)
            {
                if (LogicPersonal.LLPersonelLogin(ent))
                {
                    PersonalMainUI form = new PersonalMainUI(ent);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Yok Kayıt Olunuz ");
                }
            }
            else
            {
                MessageBox.Show("Şifreleriniz Uyuşmuyor Lütfen Kontrol Ediniz");
            }
        }

        private void StndtLoginBtn_Click(object sender, EventArgs e)
        {
            // Personel Nesnesi Üreterek gerekli atamaları yapıyoruz
            // Önce Mantıksal Katmanda gelen veriler doğru formatta gelmiş mi kontrol etmek üzere logic katmana gönderiyoruz
            EntityStudent student = new EntityStudent();
            student.StudentUserName = TxtStudentUserName.Text;
            student.Password = TxtStudentPassword1.Text;
            student.Repassword = TxtStudentPassword2.Text;
            if (TxtStudentPassword1.Text == TxtStudentPassword2.Text)
            {
                if (LogicStudent.LLStudentLogIn(student))
                {
                    StudentMain studentMainForm = new StudentMain(student);
                    studentMainForm.Show();
                }
                else
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Yok Kayıt Olunuz ");
                }
            }
            else
            {
                MessageBox.Show("Şifreleriniz Uyuşmuyor Lütfen Kontrol Ediniz");
            }
           
        }

        private void StndntRegisterBtn_Click(object sender, EventArgs e)
        {
            //Kayıt olma sayfasını farklı bir sayfada yaptırdığımız için üretilen formu show methodu ile gösteriyoruz.
            StudentSigninUI form = new StudentSigninUI();
            form.Show();
        }


    }
}
