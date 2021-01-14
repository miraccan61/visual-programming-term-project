using System;
using System.Collections.Generic;
using System.Linq;
using EntityLayer;
using System.Data.OleDb;
using System.Data;
namespace DataAccessLayer
{
    public class DALStudentRead
    {
        // Data Acceess Layer Logic Layer üzerinden erişilen bir katmandır ve SQL sorgularının çalıştırıldığı katman olarak geçer 
        // CRUD CREATE READ UPDATE DELETE operasyonları bu katmanda yazılır
        public static int StudentBookSave(StudentReadInfo stdnread)
        {
            OleDbCommand komut2 = new OleDbCommand("insert into StudentReadInfoTable (StudentID, BookID, TakenDate, GivenDate, isGiven) values (@p1,@p2,@p3,@p4,@p5)", Connection.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", stdnread.StudentId.StudentId);
            komut2.Parameters.AddWithValue("@p2", stdnread.BookId.bookID);
            komut2.Parameters.AddWithValue("@p3", Convert.ToDateTime(stdnread.TakenDate));
            komut2.Parameters.AddWithValue("@p4", Convert.ToDateTime(stdnread.GivenDate));
            komut2.Parameters.AddWithValue("@p5", Convert.ToBoolean(stdnread.isGiven));
            return komut2.ExecuteNonQuery();
        }
        public static bool StudentBookUpdate(EntityBook book)
        {
            OleDbCommand komut4 = new OleDbCommand("Update BookTable set IsBookAvailable=@p7 where bookID=@p10", Connection.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p7", book.isBookAvailable);
            komut4.Parameters.AddWithValue("@p10", book.bookID);
            return komut4.ExecuteNonQuery() > 0;
        }
        public static List<StudentReadInfo> StudentReadList()
        {
            List<StudentReadInfo> degerler = new List<StudentReadInfo>();
            OleDbCommand komut1 = new OleDbCommand("Select * from StudentReadInfoTable Order By TakenDate", Connection.baglanti);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            OleDbDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                StudentReadInfo stdnread = new StudentReadInfo();
                EntityStudent student = DALStudent.StudentList().FirstOrDefault(n => n.StudentId == int.Parse(dr["StudentID"].ToString()));
                EntityBook book = DALBook.BookList().FirstOrDefault(n => n.bookID == int.Parse(dr["BookID"].ToString()));
                stdnread.StudentId = student;
                stdnread.BookId = book;
                stdnread.TakenDate = dr["TakenDate"].ToString();
                stdnread.GivenDate = dr["GivenDate"].ToString();
                stdnread.isGiven = bool.Parse(dr["isGiven"].ToString()) ;
                degerler.Add(stdnread);
            }
            dr.Close();
            return degerler;
        }        
    }
}
