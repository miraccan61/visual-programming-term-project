using System;
namespace EntityLayer
{
    public class EntityWriter
    {
        // Veritabanında Yazarlar tablomuzu kod kısmında kullanmak için oluşturulmuştur 
        // Veritabanında bulunan her alan adının kod kısmında bir karşılığı olmalı bu yüzden entity katmanınında her tablo için propertler oluşturuyoruz
        // Burada yaptığımız işlem kapsülleme olarak bilinmektedir
        public int writerId { get; set; }
        public string writerName { get; set; }
        public string writerLastName { get; set; }
        public string writerBirth { get; set; }
        public string writerDeath { get; set; }
        public string writerGender { get; set; }
    }
}
