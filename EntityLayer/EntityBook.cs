using System;
namespace EntityLayer
{
    public class EntityBook
    {
        // Veritabanında Kitaplar tablomuzu kod kısmında kullanmak için oluşturulmuştur 
        // Veritabanında bulunan her alan adının kod kısmında bir karşılığı olmalı bu yüzden entity katmanınında her tablo için propertler oluşturuyoruz
        // Burada yaptığımız işlem kapsülleme olarak bilinmektedir
        public int bookID { get; set; }
        public String bookName { get; set; }
        public String bookISBN { get; set; }
        public String bookPublisher { get; set; }//yayın evi
        public String bookPage { get; set; }
        public String bookSummarize { get; set; }
        public String bookPublishedDate { get; set; }
        public String isBookAvailable { get; set; }

        //Burada Yaptığımız işlem EntiyCategory üzerinde bir nesne üreterek SQL'deki foreign key mantığına denk gelmektedir ve 1->n ilişki vermektedir
        public EntityCategory bookCategoryId { get; set; }
        //Burada Yaptığımız işlem EntityWriter üzerinde bir nesne üreterek SQL'deki foreign key mantığına denk gelmektedir ve 1->n ilişki vermektedir
        public EntityWriter bookWriterId { get; set; }


    }
}
