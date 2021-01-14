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
using LibraryManagement.Writer;
using LibraryManagement.Personal.CRUD;
using LibraryManagement.Student.StudentCRUD;
using LibraryManagement.Personal.PersonalCRUD;

namespace LibraryManagement.Personal
{
    public partial class PersonalMainUI : Form
    {
        public PersonalMainUI(EntityPersonal ent)
        {
            InitializeComponent();
            label1.Text = ent.PersonelName;
            label2.Text = ent.PersonelLastName;
        }

        private void BtnWriterMenu_Click(object sender, EventArgs e)
        {
            // Yazar ekleme sayfası ayrı bir formda yapılması için butona form oluşturma yaptırıldı.
            WriterMain form = new WriterMain();
            form.Show();
        }

        private void BtnStudentMenu_Click(object sender, EventArgs e)
        {
            // Öğrenci ekleme sayfası ayrı bir formda yapılması için butona form oluşturma yaptırıldı.
            StudentInformationUI form = new StudentInformationUI();
            form.Show();
        }

        private void BtnBookMenu_Click(object sender, EventArgs e)
        {
            // Kitap ekleme sayfası ayrı bir formda yapılması için butona form oluşturma yaptırıldı.
            BookInformationUI form = new BookInformationUI();
            form.Show();
        }

        private void BtnStudentBookMenu_Click(object sender, EventArgs e)
        {
            // Öğrenci kitapkayıt ekleme sayfası ayrı bir formda yapılması için butona form oluşturma yaptırıldı.
            StudentReadUI form = new StudentReadUI();
            form.Show();
        }

        private void BtnShowStudentRead_Click(object sender, EventArgs e)
        {
            // Öğrenci kitap okuma ekleme sayfası ayrı bir formda yapılması için butona form oluşturma yaptırıldı.
            StudenReadDataGrid form = new StudenReadDataGrid();
            form.Show();
        }

        private void BtnGraph_Click(object sender, EventArgs e)
        {
            // Grafik sayfası ayrı bir formda yapılması için butona form oluşturma yaptırıldı.
            GraphicsFormUI form = new GraphicsFormUI();
            form.Show();
        }
  
    }
}
