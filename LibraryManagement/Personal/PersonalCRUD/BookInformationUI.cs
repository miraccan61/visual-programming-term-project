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
//Hızlı komut ctrl + k + c yorum satırına alıyor | ctrl + k + u yorum satırını kaldırıyor
//Bitti
namespace LibraryManagement.Personal.CRUD
{
    public partial class BookInformationUI : Form
    {
        public BookInformationUI()
        {
            InitializeComponent();
        }

        private void BtnBookAdd_Click(object sender, EventArgs e)
        {
            // Textbox'lardan gelen veriler kontrol ediliyor boş veri varsa uyarı mesajı bırakıyoruz çünkü veritabanında boş verilerin bulunmasını istemiyoruz
            // EntityBook üzerinde oluşturduğumuz nesnemize gerekli atamaları yaptıktan sonra
            // Nesnelerimizin kontrolünü yapmak üzere Mantıksal Katmana verilerimizi gönderiyoruz.
            if (TxtBookName.Text != "" && TxtBookISBN.Text != "" && TxtBookPublisher.Text != "" && TxtBookPage.Text != "" && TxtBookPublishedDate.Text != "" &&
               CmbIsAvailable.SelectedItem.ToString() != "" && cmbBookCat.SelectedItem.ToString() != "" && cmbBookWriter.SelectedItem.ToString() != "")
            {
                EntityBook book = new EntityBook();
                book.bookName = TxtBookName.Text;
                book.bookISBN = TxtBookISBN.Text;
                book.bookPublisher = TxtBookPublisher.Text;
                book.bookPage = TxtBookPage.Text;
                book.bookSummarize = RTxtSummarize.Text;
                book.bookPublishedDate = TxtBookPublishedDate.Text;
                book.isBookAvailable = CmbIsAvailable.SelectedItem.ToString();
                book.bookCategoryId = DALCategory.CategoryList().FirstOrDefault(n => n.categoryName == cmbBookCat.SelectedItem.ToString());
                book.bookWriterId = DALWriter.WriterList().FirstOrDefault(n => n.writerName == cmbBookWriter.SelectedItem.ToString());
                LogicBook.LLBookSave(book);
                MessageBox.Show("Kitap Başarılı Bir Şekilde Kayıt Edildi");
                TxtBookId.Text = "";
                TxtBookName.Text = "";
                TxtBookISBN.Text = "";
                TxtBookPublisher.Text = "";
                TxtBookPage.Text = "";
                RTxtSummarize.Text = "";
                TxtBookPublishedDate.Text = "";
            }
            else
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }
        }

        private void BtnBookUpdate_Click(object sender, EventArgs e)
        {
            // Textbox'lardan gelen veriler kontrol ediliyor boş veri varsa uyarı mesajı bırakıyoruz çünkü veritabanında boş verilerin bulunmasını istemiyoruz
            // EntityBook üzerinde oluşturduğumuz nesnemize gerekli atamaları yaptıktan sonra
            // Nesnelerimizin kontrolünü yapmak üzere Mantıksal Katmana verilerimizi gönderiyoruz.
            if (TxtBookName.Text != "" && TxtBookISBN.Text != "" && TxtBookPublisher.Text != "" && TxtBookPage.Text != "" && TxtBookPublishedDate.Text != "" &&
              CmbIsAvailable.SelectedItem.ToString() != "" && cmbBookCat.SelectedItem.ToString() != "" && cmbBookWriter.SelectedItem.ToString() != "")
            {
                EntityBook book = new EntityBook();
                book.bookID = int.Parse(TxtBookId.Text);
                book.bookName = TxtBookName.Text;
                book.bookISBN = TxtBookISBN.Text;
                book.bookPublisher = TxtBookPublisher.Text;
                book.bookPage = TxtBookPage.Text;
                book.bookSummarize = RTxtSummarize.Text;
                book.bookPublishedDate = TxtBookPublishedDate.Text;
                book.isBookAvailable = CmbIsAvailable.SelectedItem.ToString();
                book.bookCategoryId = DALCategory.CategoryList().FirstOrDefault(n => n.categoryName == cmbBookCat.SelectedItem.ToString());
                book.bookWriterId = DALWriter.WriterList().FirstOrDefault(n => n.writerName == cmbBookWriter.SelectedItem.ToString());
                LogicBook.LLBookUpdate(book);
                MessageBox.Show("Kitap Başarılı Bir Şekilde Güncellendi");
                TxtBookId.Text = "";
                TxtBookName.Text = "";
                TxtBookISBN.Text = "";
                TxtBookPublisher.Text = "";
                TxtBookPage.Text = "";
                RTxtSummarize.Text = "";
                TxtBookPublishedDate.Text = "";
            }
            else
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }
        }

        private void BtnBookDelete_Click(object sender, EventArgs e)
        {
            // Sadece ID kontrol etmemiz yeterli VeriTabanından Kayıtlar Nesneyi eşsiz yapan bir özelliği üzerinden silinirler 
            // ID her kitabın benzersiz sahip olduğu bir özelliktir
            if (TxtBookId.Text != "")
            {
                EntityBook book = new EntityBook();
                book.bookID = int.Parse(TxtBookId.Text);
                LogicBook.LLBookDelete(book.bookID);
                MessageBox.Show("Kitap Veri Tabanından Silindi");
                TxtBookId.Text = "";
                TxtBookName.Text = "";
                TxtBookISBN.Text = "";
                TxtBookPublisher.Text = "";
                TxtBookPage.Text = "";
                RTxtSummarize.Text = "";
                TxtBookPublishedDate.Text = "";

            }
            else
            {
                MessageBox.Show("Id Alanını Boş Bırakmayınız");
            }
        }

        private void BtnBookList_Click(object sender, EventArgs e)
        {
            // Data Gride verileri getirmek için EntityBook class'ından BookList adında generic bir liste oluşturuyoruz ve Mantıksal Katman(Logic Layer)
            //üzerinden LLBookList methodu Veri Erişim Katmanına Erişerek (DAL) gerekli SQL sorgusu ile kitaplar hakkında tüm bilgiler getirilir.     
            List<EntityBook> BookList = LogicBook.LLBookList();
            // DataSource veri kaynağı olarak bir Generic List almaktadır
            dataGridView1.DataSource = BookList;
            dataGridView1.Columns["bookCategoryId"].Visible = false;
            dataGridView1.Columns["bookWriterId"].Visible = false;

        }

        private void BtnSearchName_Click(object sender, EventArgs e)
        {
            // Arama Yapmadan Önce TextBoxdan geçerli bir veri gelip gelmediği kontrol ettirilir.
            // Arama yaparken birden fazla nesne geleceği tahmin edildiği için
            // (veritabanında tam arama yapılmıyor >like< ile benzer aramalar getirilir)
            // Generic List oluşturarak işlemler yaptırılır
            if (TxtSearchName.Text != "")
            {
                EntityBook book = new EntityBook();
                book.bookName = TxtSearchName.Text;
                List<EntityBook> BookList = LogicBook.LLBookList();
                var liste = from b in BookList
                            where b.bookName.Contains(book.bookName)
                            select new
                            {
                                Id = b.bookID,
                                BookName = b.bookName,
                                BookISBN = b.bookISBN,
                                BookPublisher = b.bookPublisher,
                                BookPage = b.bookPage,
                                BookPublishedDate = b.bookPublishedDate
                            };
                dataGridView1.DataSource = liste.ToList();
                TxtSearchName.Text = "";
            }
            else
            {
                MessageBox.Show("Arama Alanını Boş Bırakmayınız");
            }
        }

        private void BtnSearchISBN_Click(object sender, EventArgs e)
        {
            // Arama Yapmadan Önce TextBoxdan geçerli bir veri gelip gelmediği kontrol ettirilir.
            // Arama yaparken birden fazla nesne geleceği tahmin edildiği için
            // (veritabanında tam arama yapılmıyor >like< ile benzer aramalar getirilir)
            // Generic List oluşturarak işlemler yaptırılır
            if (TxtISBN.Text != "")
            {
                EntityBook book = new EntityBook();
                book.bookISBN = TxtISBN.Text;
                List<EntityBook> BookList = LogicBook.LLBookList();
                var liste = from b in BookList
                            where b.bookISBN.Contains(book.bookISBN)
                            select new
                            {
                                Id = b.bookID,
                                BookName = b.bookName,
                                BookISBN = b.bookISBN,
                                BookPublisher = b.bookPublisher,
                                BookPage = b.bookPage,
                                BookPublishedDate = b.bookPublishedDate
                            };
                dataGridView1.DataSource = liste.ToList();
                TxtISBN.Text = "";
            }
            else
            {
                MessageBox.Show("Arama Alanını Boş Bırakmayınız");
            }

        }

        private void BtnCategoryAdd_Click(object sender, EventArgs e)
        {
            // Kategori Ekleme Sayfası ayrı bir formda yapılması için butona form oluşturma yaptırıldı.
            CategoryInformationUI form = new CategoryInformationUI();
            form.Show();
        }

        private void BtnWriterAdd_Click(object sender, EventArgs e)
        {
            // Yazar Ekleme Sayfası ayrı bir formda yapılması için butona form oluşturma yaptırıldı.
            WriterMain form = new WriterMain();
            form.Show();
        }


        int counterCategory = 0;
        private void BtnCatUpdt_Click(object sender, EventArgs e)
        {
            counterCategory += 1;
            if (counterCategory < 2)
            {
                // ComboBox kategorileri getirmek için Logic Layer'de daha önce tanımlanan LLCategoryList methodu ile tüm kategoriler getirilir
                // gelen liste foreach ile dönülerek combobox'ın add methodu ile comboxa eklenir

                List<EntityCategory> CatList = LogicCategory.LLCategoryList();
                foreach (var item in CatList)
                {
                    cmbBookCat.Items.Add(item.categoryName);
                }
            }
            else
            {
                MessageBox.Show("Butona sadece bir kez basabilirsiniz");
            }

        }
        int counterWriter = 0;
        private void BtnWriterUpt_Click(object sender, EventArgs e)
        {
            counterWriter += 1;
            if (counterWriter < 2)
            {
                // ComboBox Yazarları getirmek için Logic Layer'de daha önce tanımlanan LLWriterList methodu ile tüm kategoriler getirilir
                // gelen liste foreach ile dönülerek combobox'ın add methodu ile comboxa eklenir
                List<EntityWriter> writerList = LogicWriter.LLWriterList();
                foreach (var item in writerList)
                {
                    cmbBookWriter.Items.Add(item.writerName);
                }
            }
            else
            {
                MessageBox.Show("Butona sadece bir kez basabilirsiniz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtBookId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBookName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtBookISBN.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtBookPublisher.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtBookPage.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            RTxtSummarize.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtBookPublishedDate.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            CmbIsAvailable.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
