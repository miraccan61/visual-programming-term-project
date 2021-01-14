using System.Collections.Generic;
using EntityLayer;
using DataAccessLayer;
namespace LogicLayer
{
    public class LogicPersonal
    {
        // Logic Layer ana form üzerinden erişilen bir katmandır ve gerekli mantıksal kontrollerin katman olarak geçer 
        // Gerekli kontrolleri başarılı bir şekilde geçen Logic Methodlar Data Access Layerdan uygun methodu çağırarak programın çalışmasına devam edilir
        public static int LLPersonalSave(EntityPersonal personal)
        {
            if(personal.PersonelName != "" && personal.PersonelLastName !="" && personal.PersonelPassword!= "" && personal.PersonelRepassword != "" && personal.PersonelPassword == personal.PersonelRepassword)
            {
                return DALPersonal.PersonalSave(personal);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLPersonalUpdate(EntityPersonal ent)
        {
            if (ent.PersonelName != "" && ent.PersonelLastName != "" && ent.PersonelUserName != "" && ent.PersonelGender != "" && ent.PersonelPassword != "")
            {
                return DALPersonal.PersonalUpdate(ent);
            }
            else
            {
                return false;
            }
        }
        public static bool LLPersonalDelete(int personal)
        {
            if(personal >= 1)
            {
                return DALPersonal.PersonalDelete(personal);
            }
            else
            {
                return false;
            }
        }
        public static List<EntityPersonal> LLPersonalList()
        {
            return DALPersonal.PersonalList();
        }
        public static bool LLPersonelLogin(EntityPersonal ent)
        {
            foreach(EntityPersonal item in DALPersonal.PersonalList())
            {
                if (item.PersonelUserName == ent.PersonelUserName && item.PersonelPassword == ent.PersonelPassword)
                {
                    ent.PersonelId = item.PersonelId;
                    ent.PersonelName = item.PersonelName;
                    ent.PersonelLastName = item.PersonelLastName;
                    ent.PersonelGender = item.PersonelGender;
                    return true;
                }              
            }
            return false;
        }
        public static int LLStudentSave(EntityStudent student)
        {
            if (student.StudentName != "" && student.StudentLastName != "" && student.StudentGender != "")
            {
                return DALPersonal.StudentSave(student);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLStudentUpdate(EntityStudent ent)
        {
            if (ent.StudentName != "" && ent.StudentLastName != "" && ent.Password != "" && ent.Repassword != "")
            {
           
                return DALPersonal.StudentUpdate(ent);
            }
            else
            {
                return false;
            }
        }
        public static bool LLStudentDelete(int student)
        {
            if (student >= 1)
            {
                return DALPersonal.StudentDelete(student);
            }
            else
            {
                return false;
            }
        }
    }
}
