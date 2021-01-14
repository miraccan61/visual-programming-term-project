using System.Collections.Generic;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicBook
    {
        // Logic Layer ana form üzerinden erişilen bir katmandır ve gerekli mantıksal kontrollerin katman olarak geçer 
        // Gerekli kontrolleri başarılı bir şekilde geçen Logic Methodlar Data Access Layerdan uygun methodu çağırarak programın çalışmasına devam edilir
        public static int LLBookSave(EntityBook book)
        { 
            if (book.bookID.ToString() != "" && book.bookName!= "" && book.bookISBN != "" && book.bookPublisher != "" && book.bookPage != "" &&
                book.bookSummarize!="" && book.bookPublishedDate != "" && book.isBookAvailable != "" && book.bookCategoryId.categoryId.ToString() != "" &&
                book.bookWriterId.writerId.ToString() != "")
            {
                //burada sifreyi sifrele
                return DALBook.BookSave(book);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLBookUpdate(EntityBook book)
        {
            if (book.bookID.ToString() != "" && book.bookName != "" && book.bookISBN != "" && book.bookPublisher != "" && book.bookPage != "" &&
                book.bookSummarize != "" && book.bookPublishedDate != "" && book.isBookAvailable != "" && book.bookCategoryId.categoryId.ToString() != "" &&
                book.bookWriterId.writerId.ToString() != "")
            {
                return DALBook.BookUpdate(book);
            }
            else
            {
                return false;
            }
        }
        public static bool LLBookDelete(int cat)
        {
            if (cat >= 1)
            {
                return DALBook.BookDelete(cat);
            }
            else
            {
                return false;
            }
        }     
        public static List<EntityBook> LLBookList()
        {
            return DALBook.BookList();
        }

    }
}
