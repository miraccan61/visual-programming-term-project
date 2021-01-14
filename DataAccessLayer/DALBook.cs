using System.Collections.Generic;
using System.Linq;
using EntityLayer;
using System.Data.OleDb;
using System.Data;
namespace DataAccessLayer
{
    public class DALBook
    {
        // Data Acceess Layer Logic Layer üzerinden erişilen bir katmandır ve SQL sorgularının çalıştırıldığı katman olarak geçer 
        // CRUD CREATE READ UPDATE DELETE operasyonları bu katmanda yazılır     
        public static int BookSave(EntityBook book)
        {
            OleDbCommand komut2 = new OleDbCommand("INSERT INTO BookTable (bookName, bookISBN, bookPublisher,bookPage,bookSummarize,categoryID,IsBookAvailable,bookPublishedDate,writerID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", Connection.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", book.bookName);
            komut2.Parameters.AddWithValue("@p2", book.bookISBN);
            komut2.Parameters.AddWithValue("@p3", book.bookPublisher);
            komut2.Parameters.AddWithValue("@p4", book.bookPage);
            komut2.Parameters.AddWithValue("@p5", book.bookSummarize);
            komut2.Parameters.AddWithValue("@p6", book.bookCategoryId.categoryId);
            komut2.Parameters.AddWithValue("@p7", book.isBookAvailable);
            komut2.Parameters.AddWithValue("@p8", book.bookPublishedDate);
            komut2.Parameters.AddWithValue("@p9", book.bookWriterId.writerId);
            return komut2.ExecuteNonQuery();
        }     
        public static bool BookUpdate(EntityBook book)
        {
            OleDbCommand komut4 = new OleDbCommand("Update BookTable set bookName=@p1,bookISBN=@p2,bookPublisher=@p3,bookPage=@p4,bookSummarize=@p5,categoryID=@p6,IsBookAvailable=@p7,bookPublishedDate=@p8,writerID=@p9 where bookID=@p10", Connection.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", book.bookName);
            komut4.Parameters.AddWithValue("@p2", book.bookISBN);
            komut4.Parameters.AddWithValue("@p3", book.bookPublisher);
            komut4.Parameters.AddWithValue("@p4", book.bookPage);
            komut4.Parameters.AddWithValue("@p5", book.bookSummarize);
            komut4.Parameters.AddWithValue("@p6", book.bookCategoryId.categoryId);
            komut4.Parameters.AddWithValue("@p7", book.isBookAvailable);
            komut4.Parameters.AddWithValue("@p8", book.bookPublishedDate);
            komut4.Parameters.AddWithValue("@p9", book.bookWriterId.writerId);
            komut4.Parameters.AddWithValue("@p10", book.bookID);
            return komut4.ExecuteNonQuery() > 0;
        }    
        public static bool BookDelete(int bookId)
        {
            OleDbCommand komut3 = new OleDbCommand("Delete from BookTable where bookID=@p1", Connection.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", bookId);
            return komut3.ExecuteNonQuery() > 0;
        }   
        public static List<EntityBook> BookList()
        {
            List<EntityBook> degerler = new List<EntityBook>();
            OleDbCommand komut1 = new OleDbCommand("Select * from BookTable", Connection.baglanti);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            OleDbDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityBook book = new EntityBook();
                book.bookID = int.Parse(dr["BookId"].ToString());
                book.bookName = dr["bookName"].ToString();
                book.bookISBN = dr["bookISBN"].ToString();
                book.bookPublisher = dr["bookPublisher"].ToString();
                book.bookPage = dr["bookPage"].ToString();
                book.bookSummarize = dr["bookSummarize"].ToString();
                book.bookPublishedDate = dr["bookPublishedDate"].ToString();
                book.isBookAvailable = dr["isBookAvailable"].ToString();
                // Category ve writer IDleri listelemede göster
                //book.bookCategoryId.categoryId = int.Parse(dr["categoryID"].ToString());
                //book.bookWriterId.writerId = int.Parse(dr["writerID"].ToString());
                book.bookCategoryId = DALCategory.CategoryList().First(x => x.categoryId == int.Parse(dr["categoryID"].ToString()));
                book.bookWriterId = DALWriter.WriterList().First(x => x.writerId == int.Parse(dr["writerID"].ToString()));
                degerler.Add(book);
            }
            dr.Close();
            return degerler;
        }
    }
}
