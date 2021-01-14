using System.Collections.Generic;
using EntityLayer;
using DataAccessLayer;
namespace LogicLayer
{
    public class LogicStudentRead
    {
        // Logic Layer ana form üzerinden erişilen bir katmandır ve gerekli mantıksal kontrollerin katman olarak geçer 
        // Gerekli kontrolleri başarılı bir şekilde geçen Logic Methodlar Data Access Layerdan uygun methodu çağırarak programın çalışmasına devam edilir
        public static int LLStudentBookSave(StudentReadInfo studentread)
        {
            if (studentread.StudentId.StudentId.ToString() != "" && studentread.BookId.bookID.ToString() != "")
            {
                return DALStudentRead.StudentBookSave(studentread);
            }
            else
            {
                return -1;
            }

        }    
        public static bool LLStudentBookUpdate(EntityBook book)
        {
            if (book.bookName != "")
            {
                return DALStudentRead.StudentBookUpdate(book);
            }
            else
            {
                return false;
            }
        }    
        public static List<StudentReadInfo> LLStudentReadList()
        {
            
            return DALStudentRead.StudentReadList();
        }
    }
}
