using System.Collections.Generic;
using EntityLayer;
using System.Data.OleDb;
using System.Data;
namespace DataAccessLayer
{
    public class DALStudent
    {
        // Data Acceess Layer Logic Layer üzerinden erişilen bir katmandır ve SQL sorgularının çalıştırıldığı katman olarak geçer 
        // CRUD CREATE READ UPDATE DELETE operasyonları bu katmanda yazılır
        public static int StudentSignin(EntityStudent student)
        {
            OleDbCommand komut2 = new OleDbCommand("insert into StudentTable (StudentName,StudentLastName,StudentPassword,StudentUserName) values (@p1,@p2,@p3,@p4)", Connection.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", student.StudentName);
            komut2.Parameters.AddWithValue("@p2", student.StudentLastName);
            komut2.Parameters.AddWithValue("@p3", student.Password);
            komut2.Parameters.AddWithValue("@p4", student.StudentUserName);
            return komut2.ExecuteNonQuery();
        }   
        public static bool StudentUpdate(EntityStudent ent)
        {
            OleDbCommand komut6 = new OleDbCommand("Update StudentTable set StudentName=@p1, StudentLastName=@p2 , StudentPassword=@p3, StudentUserName=@p4 where StudentID=@p5", Connection.baglanti);
            if (komut6.Connection.State != ConnectionState.Open)
            {
                komut6.Connection.Open();
            }
            komut6.Parameters.AddWithValue("@p1", ent.StudentName);
            komut6.Parameters.AddWithValue("@p2", ent.StudentLastName);
            komut6.Parameters.AddWithValue("@p3", ent.Password);
            komut6.Parameters.AddWithValue("@p4", ent.StudentUserName);
            komut6.Parameters.AddWithValue("@p5", ent.StudentId);

            return komut6.ExecuteNonQuery() > 0;

        }    
        public static List<EntityStudent> StudentList()
        {
            List<EntityStudent> degerler = new List<EntityStudent>();
            OleDbCommand komut6 = new OleDbCommand("Select * from StudentTable", Connection.baglanti);
            if (komut6.Connection.State != ConnectionState.Open)
            {
                komut6.Connection.Open();
            }

            OleDbDataReader dr = komut6.ExecuteReader();
            while (dr.Read())
            {
                EntityStudent ent = new EntityStudent();
                ent.StudentId = int.Parse(dr["StudentID"].ToString());
                ent.StudentName = dr["StudentName"].ToString();
                ent.StudentLastName = dr["StudentLastName"].ToString();
                ent.StudentUserName = dr["StudentUserName"].ToString();
                ent.Password = dr["StudentPassword"].ToString();
                ent.StudentDebt = int.Parse(dr["StudentDebt"].ToString());
                ent.StudentGender = dr["StudentGender"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
