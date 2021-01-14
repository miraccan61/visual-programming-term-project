using System;
namespace EntityLayer
{
    public class EntityStudent
    {
        // Veritabanında Öğrenciler tablomuzu kod kısmında kullanmak için oluşturulmuştur 
        // Veritabanında bulunan her alan adının kod kısmında bir karşılığı olmalı bu yüzden entity katmanınında her tablo için propertler oluşturuyoruz
        private int studentId;
        private string studentName;
        private string studentLastName;    
        private string password;
        private string repassword;
        private int studentDebt;
        private string studentGender;
        private string studentUserName;

        // Kapsülleme yapılır bunu yapmamızdaki amaç veri güvenliği sağlamak
        public int StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentLastName { get => studentLastName; set => studentLastName = value; }
        public string Password { get => password; set => password = value; }
        public string Repassword { get => repassword; set => repassword = value; }
        public int StudentDebt { get => studentDebt; set => studentDebt = value; }
        public string StudentGender { get => studentGender; set => studentGender = value; }
        public string StudentUserName { get => studentUserName; set => studentUserName = value; }
    }
}
