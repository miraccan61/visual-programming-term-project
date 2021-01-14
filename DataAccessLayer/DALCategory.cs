using System.Collections.Generic;
using EntityLayer;
using System.Data.OleDb;
using System.Data;
namespace DataAccessLayer
{
    public class DALCategory
    {
        // Data Acceess Layer Logic Layer üzerinden erişilen bir katmandır ve SQL sorgularının çalıştırıldığı katman olarak geçer 
        // CRUD CREATE READ UPDATE DELETE operasyonları bu katmanda yazılır    
        public static int CategorySave(EntityCategory cat)
        {
            OleDbCommand komut2 = new OleDbCommand("insert into CategoryTable (CategoryName) values (@p1)", Connection.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", cat.categoryName);
            return komut2.ExecuteNonQuery();
        }
        public static bool CategoryUpdate(EntityCategory cat)
        {
            OleDbCommand komut4 = new OleDbCommand("Update CategoryTable set CategoryName=@p1 where CategoryID=@p2", Connection.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", cat.categoryName);
            komut4.Parameters.AddWithValue("@p2", cat.categoryId);
            return komut4.ExecuteNonQuery() > 0;

        }
        public static bool CategoryDelete(int categoryId)
        {
            OleDbCommand komut3 = new OleDbCommand("Delete from CategoryTable where CategoryID=@p1 ", Connection.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", categoryId);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static List<EntityCategory> CategoryList()
        {
            List<EntityCategory> degerler = new List<EntityCategory>();
            OleDbCommand komut1 = new OleDbCommand("Select * from CategoryTable", Connection.baglanti);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            OleDbDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityCategory ent = new EntityCategory();
                ent.categoryId = int.Parse(dr["CategoryID"].ToString());
                ent.categoryName = dr["CategoryName"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
