using System.Collections.Generic;
using EntityLayer;
using System.Data.OleDb;
using System.Data;
namespace DataAccessLayer
{
    public class DALPersonal
    {
        // Data Acceess Layer Logic Layer üzerinden erişilen bir katmandır ve SQL sorgularının çalıştırıldığı katman olarak geçer 
        // CRUD CREATE READ UPDATE DELETE operasyonları bu katmanda yazılır
        public static int PersonalSave(EntityPersonal Personal)
        {
            OleDbCommand komut2 = new OleDbCommand("insert into PersonalTable (PersonalName,PersonalLastName,PersonalPassword,PersonalUserName,PersonalGender) values (@p1,@p2,@p3,@p4,@p5)", Connection.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", Personal.PersonelName);
            komut2.Parameters.AddWithValue("@p2", Personal.PersonelLastName);
            komut2.Parameters.AddWithValue("@p3", Personal.PersonelPassword);
            komut2.Parameters.AddWithValue("@p4", Personal.PersonelUserName);
            komut2.Parameters.AddWithValue("@p5", Personal.PersonelGender);
            return komut2.ExecuteNonQuery();
        }
        public static bool PersonalUpdate(EntityPersonal ent)
        {
            OleDbCommand komut4 = new OleDbCommand("Update PersonalTable set PersonalName=@p1, PersonalLastName=@p2 , PersonalPassword=@p3, PersonalGender=@p4,PersonalUserName=@p5 where PersonalID=@p6", Connection.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", ent.PersonelName);
            komut4.Parameters.AddWithValue("@p2", ent.PersonelLastName);
            komut4.Parameters.AddWithValue("@p3", ent.PersonelPassword);
            komut4.Parameters.AddWithValue("@p4", ent.PersonelGender);
            komut4.Parameters.AddWithValue("@p5", ent.PersonelUserName);
            komut4.Parameters.AddWithValue("@p6", ent.PersonelId);


            return komut4.ExecuteNonQuery() > 0;
        }
        public static bool PersonalDelete(int personal)
        {
            OleDbCommand komut3 = new OleDbCommand("Delete from PersonalTable where PersonalID=@p1 ", Connection.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", personal);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static List<EntityPersonal> PersonalList()
        {
            List<EntityPersonal> degerler = new List<EntityPersonal>();
            OleDbCommand komut1 = new OleDbCommand("Select * from PersonalTable", Connection.baglanti);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            OleDbDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonal ent = new EntityPersonal();
                ent.PersonelId = int.Parse(dr["PersonalID"].ToString());
                ent.PersonelName = dr["PersonalName"].ToString();
                ent.PersonelLastName = dr["PersonalLastName"].ToString();
                ent.PersonelPassword = dr["PersonalPassword"].ToString();
                ent.PersonelGender = dr["PersonalGender"].ToString();
                ent.PersonelUserName = dr["PersonalUserName"].ToString();

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int StudentSave(EntityStudent student)
        {
            OleDbCommand komut5 = new OleDbCommand("Insert into StudentTable (StudentName,StudentLastName,StudentGender,StudentDebt,StudentUserName,StudentPassword) values (@p1,@p2,@p3,@p4,@p5,@p6)", Connection.baglanti);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", student.StudentName);
            komut5.Parameters.AddWithValue("@p2", student.StudentLastName);
            komut5.Parameters.AddWithValue("@p3", student.StudentGender);
            komut5.Parameters.AddWithValue("@p4", student.StudentDebt);
            komut5.Parameters.AddWithValue("@p5", student.StudentUserName);
            komut5.Parameters.AddWithValue("@p6", student.Password);
            return komut5.ExecuteNonQuery();
        }       
        public static bool StudentUpdate(EntityStudent ent)
        {
            OleDbCommand komut6 = new OleDbCommand("Update StudentTable set StudentName=@p1, StudentLastName=@p2 , StudentPassword=@p3,StudentDebt=@p4,StudentGender=@p5,StudentUserName=@p6 where StudentID=@p7", Connection.baglanti);
            if (komut6.Connection.State != ConnectionState.Open)
            {
                komut6.Connection.Open();
            }
            komut6.Parameters.AddWithValue("@p1", ent.StudentName);
            komut6.Parameters.AddWithValue("@p2", ent.StudentLastName);
            komut6.Parameters.AddWithValue("@p3", ent.Password);
            komut6.Parameters.AddWithValue("@p4",ent.StudentDebt);
            komut6.Parameters.AddWithValue("@p5", ent.StudentGender);
            komut6.Parameters.AddWithValue("@p6", ent.StudentUserName);
            komut6.Parameters.AddWithValue("@p7", ent.StudentId);

            return komut6.ExecuteNonQuery() > 0;

        }    
        public static bool StudentDelete(int personal)
        {
            OleDbCommand komut3 = new OleDbCommand("Delete from StudentTable where StudentID=@p1 ", Connection.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", personal);
            return komut3.ExecuteNonQuery() > 0;
        }
    }
}