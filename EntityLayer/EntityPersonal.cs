using System;
namespace EntityLayer
{
    public class EntityPersonal
    {
        // Veritabanında Personeller tablomuzu kod kısmında kullanmak için oluşturulmuştur 
        // Veritabanında bulunan her alan adının kod kısmında bir karşılığı olmalı bu yüzden entity katmanınında her tablo için propertler oluşturuyoruz
        private int personelId;
        private string personelName;
        private string personelLastName;
        private string personelPassword;
        private string personelRepassword;
        private string personelGender;
        private string personelUserName;
        // Kapsülleme yapılır bunu yapmamızdaki amaç veri güvenliği sağlamak
        public int PersonelId { get => personelId; set => personelId = value; }
        public string PersonelName { get => personelName; set => personelName = value; }
        public string PersonelLastName { get => personelLastName; set => personelLastName = value; }
        public string PersonelPassword { get => personelPassword; set => personelPassword = value; }
        public string PersonelRepassword { get => personelRepassword; set => personelRepassword = value; }
        public string PersonelGender { get => personelGender; set => personelGender = value; }
        public string PersonelUserName { get => personelUserName; set => personelUserName = value; }
    }
}
