using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using DataAccessLayer;
using ZedGraph;
namespace LibraryManagement
{
    public partial class GraphicsFormUI : Form
    {
        GraphPane graphPane;
        public GraphicsFormUI()
        {
            InitializeComponent();
            bookInfo();
            writerGenderInfo();
            studentGenderInfo();
            personalGenderInfo();
            bookPublishedInfo();
            //DrawSineCurve();
        }
        //private void DrawSineCurve()
        //{
        //    PointPairList _pointPairList = new PointPairList();

        //    for (int i = 1945; i <= DateTime.Now.Year; i++)
        //    {
        //        int a = DALBook.BookList().Where(m => Convert.ToDateTime(m.bookPublishedDate).Year == i).Count();
        //        if (a == 0)
        //            continue;
        //        PointPair _pointPair = new PointPair(i, a);
        //        _pointPairList.Add(_pointPair);
        //        var _lineItem = graphPane.AddCurve("Tarih", _pointPairList, Color.Red);

        //    }

        //    zedGraphControl1.AxisChange();


        //}
        private void bookInfo()
        {
            int available = DALBook.BookList().Where(m=>m.isBookAvailable== "Available").Count();
            int busy = DALBook.BookList().Where(m=>m.isBookAvailable== "Busy").Count();
            chart1.Titles.Add("Book Info");
            chart1.Series["Kitap"].IsValueShownAsLabel = true;
            chart1.Series["Kitap"].Points.AddXY("Kitap Alan", available);
            chart1.Series["Kitap"].Points.AddXY("Kitap Veren", busy);
        }
        private void writerGenderInfo()
        {
            int erkek = DALWriter.WriterList().Where(m => m.writerGender == "ERKEK").Count();
            int kadın = DALWriter.WriterList().Where(m => m.writerGender == "KADIN").Count();
            chart2.Titles.Add("Writer Gender Info");
            chart2.Series["Yazar"].IsValueShownAsLabel = true;
            chart2.Series["Yazar"].Points.AddXY("Erkek", erkek);
            chart2.Series["Yazar"].Points.AddXY("Kadın", kadın);
        }
        private void studentGenderInfo()
        {

            int erkek = DALStudent.StudentList().Where(m => m.StudentGender == "ERKEK").Count();
            int kadın = DALStudent.StudentList().Where(m => m.StudentGender == "KADIN").Count();
            chart3.Titles.Add("Student Gender Info");
            chart3.Series["Öğrenci"].IsValueShownAsLabel = true;
            chart3.Series["Öğrenci"].Points.AddXY("Erkek", erkek);
            chart3.Series["Öğrenci"].Points.AddXY("Kadın", kadın);
        }
        private void personalGenderInfo()
        {

            int erkek = DALPersonal.PersonalList().Where(m => m.PersonelGender == "ERKEK").Count();
            int kadın = DALPersonal.PersonalList().Where(m => m.PersonelGender == "KADIN").Count();
            chart4.Titles.Add("Personel Gender Info");
            chart4.Series["Personal"].IsValueShownAsLabel = true;
            chart4.Series["Personal"].Points.AddXY("Erkek", erkek);
            chart4.Series["Personal"].Points.AddXY("Kadın", kadın);
        }
        private void bookPublishedInfo()
        {
            chart5.Titles.Add("Book Publish Info");
            chart5.Series["Kitap"].IsValueShownAsLabel = true;


            //var pd = DALBook.BookList().Where(m => Convert.ToDateTime(m.bookPublishedDate)< localDate);
            //var bookName = DALBook.BookList().Select(m => m.bookName);
            foreach (var item in DALCategory.CategoryList())
            {
                int count = DALBook.BookList().Where(m => m.bookCategoryId.categoryId  == item.categoryId).Count();
                chart5.Series["Kitap"].Points.AddXY(item.categoryName,count);
            }    
        }

        private void GraphicsFormUI_Load(object sender, EventArgs e)
        {

        }
    }
}
