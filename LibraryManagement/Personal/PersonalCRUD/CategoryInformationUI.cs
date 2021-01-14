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
    public partial class CategoryInformationUI : Form
    {
        public CategoryInformationUI()
        {
            InitializeComponent();
        }

        private void BtnCatAdd_Click(object sender, EventArgs e)
        {
            // Textbox'lardan gelen veriler kontrol ediliyor boş veri varsa uyarı mesajı bırakıyoruz çünkü veritabanında boş verilerin bulunmasını istemiyoruz
            // EntityCategory üzerinde oluşturduğumuz nesnemize gerekli atamaları yaptıktan sonra
            // Nesnelerimizin kontrolünü yapmak üzere Mantıksal Katmana verilerimizi gönderiyoruz.
            if (TxtCatName.Text != "")
            {
                EntityCategory cat = new EntityCategory();
                cat.categoryName = TxtCatName.Text;
                LogicCategory.LLCategorySave(cat);
                MessageBox.Show("Kategori Başarılı Bir Şekilde Eklendi");
                TxtCatName.Text="";
            }
            else
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }
        }

        private void BtnCatUpdate_Click(object sender, EventArgs e)
        {
            // Textbox'lardan gelen veriler kontrol ediliyor boş veri varsa uyarı mesajı bırakıyoruz çünkü veritabanında boş verilerin bulunmasını istemiyoruz
            // EntityCategory üzerinde oluşturduğumuz nesnemize gerekli atamaları yaptıktan sonra
            // Nesnelerimizin kontrolünü yapmak üzere Mantıksal Katmana verilerimizi gönderiyoruz.
            if (TxtCatName.Text != "")
            {
                EntityCategory cat = new EntityCategory();
                cat.categoryId = int.Parse(TxtCatId.Text);
                cat.categoryName = TxtCatName.Text;
                LogicCategory.LLCategoryUpdate(cat);
                MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi");
                TxtCatName.Text = "";
            }
            else
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }
        }

        private void BtnCatDelete_Click(object sender, EventArgs e)
        {
            // Sadece ID kontrol etmemiz yeterli VeriTabanından Kayıtlar Nesneyi eşsiz yapan bir özelliği üzerinden silinirler 
            // ID her kategorinin benzersiz sahip olduğu bir özelliktir
            if (TxtCatId.Text != "")
            {
                EntityCategory ent = new EntityCategory();
                ent.categoryId = int.Parse(TxtCatId.Text);
                LogicCategory.LLCategoryDelete(ent.categoryId);
                MessageBox.Show("Kategori Başarılı Bir Şekilde Silindi");
                TxtCatName.Text = "";
            }
            else
            {
                MessageBox.Show("Id Alanını Boş Bırakmayınız");
            }
        }

        private void BtnCatList_Click(object sender, EventArgs e)
        {
            // Data Gride verileri getirmek için EntityCategory class'ından CategoryList adında generic bir liste oluşturuyoruz ve Mantıksal Katman(Logic Layer)
            // üzerinden LLCategoryList methodu Veri Erişim Katmanına Erişerek (DAL) gerekli SQL sorgusu ile kategoriler hakkında tüm bilgiler getirilir.
            List<EntityCategory> CategoryList = LogicCategory.LLCategoryList();
            // DataSource veri kaynağı olarak bir Generic List almaktadır
            dataGridView1.DataSource = CategoryList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtCatId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtCatName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
