using System;
namespace EntityLayer
{
    public class StudentReadInfo
    {
        // Veritabanında Öğrencinin Okuduğu Kitapların Bilgisini tutan tablomuzu kod kısmında kullanmak için oluşturulmuştur 
        // Veritabanında bulunan her alan adının kod kısmında bir karşılığı olmalı bu yüzden entity katmanınında her tablo için propertler oluşturuyoruz
        // Burada yaptığımız işlem kapsülleme olarak bilinmektedir
        public int StudentReadInfoID { get; set; }
        public EntityStudent StudentId { get; set; }
        public EntityBook BookId { get; set; }
        public String TakenDate { get; set; }
        public String GivenDate { get; set; }
        public bool isGiven { get; set; }
    }
}
