using System;
namespace EntityLayer
{
    public class EntityCategory
    {
        // Veritabanında kategoriler tablomuzu kod kısmında kullanmak için oluşturulmuştur 
        // Veritabanında bulunan her alan adının kod kısmında bir karşılığı olmalı bu yüzden entity katmanınında her tablo için propertler oluşturuyoruz
        // Burada yaptığımız işlem kapsülleme olarak bilinmektedir
        public int categoryId { get; set; }
        public String categoryName { get; set; }
    }
}
