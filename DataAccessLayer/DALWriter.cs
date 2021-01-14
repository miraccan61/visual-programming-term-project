using System.Collections.Generic;
using EntityLayer;
using System.Data.OleDb;
using System.Data;

namespace DataAccessLayer
{
    public class DALWriter
    {
        // Data Acceess Layer Logic Layer üzerinden erişilen bir katmandır ve SQL sorgularının çalıştırıldığı katman olarak geçer 
        // CRUD CREATE READ UPDATE DELETE operasyonları bu katmanda yazılır
        public static List<EntityWriter> WriterList()
        {
            List<EntityWriter> degerler = new List<EntityWriter>();
            OleDbCommand komut1 = new OleDbCommand("Select * from WriterTable", Connection.baglanti);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            OleDbDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityWriter ent = new EntityWriter();
                ent.writerId = int.Parse(dr["WriterID"].ToString());
                ent.writerName = dr["WriterName"].ToString();
                ent.writerLastName = dr["WriterLastName"].ToString();
                ent.writerBirth = dr["WriterBirth"].ToString();
                ent.writerDeath = dr["WriterDeath"].ToString();
                ent.writerGender = dr["WriterGender"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool WriterUpdate(EntityWriter writer)
        {
            OleDbCommand komut4 = new OleDbCommand("Update WriterTable set WriterName=@p1, WriterLastName=@p2,WriterBirth=@p3,WriterDeath=@p4,WriterGender=@p5 where WriterID=@p6", Connection.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", writer.writerName);
            komut4.Parameters.AddWithValue("@p2", writer.writerLastName);
            komut4.Parameters.AddWithValue("@p3", writer.writerBirth);
            komut4.Parameters.AddWithValue("@p4", writer.writerDeath);
            komut4.Parameters.AddWithValue("@p5", writer.writerGender);
            komut4.Parameters.AddWithValue("@p6", writer.writerId);
            return komut4.ExecuteNonQuery() > 0;


        }
        public static bool WriterDelete(int writerId)
        {
            OleDbCommand komut3 = new OleDbCommand("Delete from WriterTable where WriterID=@p1 ", Connection.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", writerId);
            return komut3.ExecuteNonQuery() > 0;


        }
        public static int WriterSave(EntityWriter writer)
        {
            OleDbCommand komut2 = new OleDbCommand("insert into WriterTable (WriterName, WriterLastName, WriterBirth, WriterDeath, WriterGender) values (@p1,@p2,@p3,@p4,@p5)", Connection.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", writer.writerName);
            komut2.Parameters.AddWithValue("@p2", writer.writerLastName);
            komut2.Parameters.AddWithValue("@p3", writer.writerBirth);
            komut2.Parameters.AddWithValue("@p4", writer.writerDeath);
            komut2.Parameters.AddWithValue("@p5", writer.writerGender);
            return komut2.ExecuteNonQuery();
        }
    }
}
