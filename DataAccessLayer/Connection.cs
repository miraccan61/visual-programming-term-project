using System.Data.OleDb;
namespace DataAccessLayer
{
    public class Connection
    {
        // Access Database için bağlantı adresini static bir şekilde üretiyoruz. Her yerden erişebilmek içinde public yapıyoruz.
        public static OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\LibraryManagement2020version2000.mdb;Persist Security Info=True");
    }
}
