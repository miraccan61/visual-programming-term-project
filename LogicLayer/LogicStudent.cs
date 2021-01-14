using System.Collections.Generic;
using EntityLayer;
using DataAccessLayer;
namespace LogicLayer
{
    public class LogicStudent
    {
        // Logic Layer ana form üzerinden erişilen bir katmandır ve gerekli mantıksal kontrollerin katman olarak geçer 
        // Gerekli kontrolleri başarılı bir şekilde geçen Logic Methodlar Data Access Layerdan uygun methodu çağırarak programın çalışmasına devam edilir
        public static int LLStudentSignIn(EntityStudent student)
        {
            if (student.StudentUserName != "" &&student.StudentName != "" && student.StudentLastName != "" && student.Password != "" && student.Repassword != "" && student.Password == student.Repassword)
            {
                return DALStudent.StudentSignin(student);
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

                return DALStudent.StudentUpdate(ent);
            }
            else
            {
                return false;
            }

        }
        public static bool LLStudentLogIn(EntityStudent student)
        {
            foreach(EntityStudent item in DALStudent.StudentList())
            {
                if (item.StudentUserName == student.StudentUserName && item.Password == student.Password)
                {
                    student.StudentId = item.StudentId;
                    student.StudentName = item.StudentName;
                    student.StudentLastName = item.StudentLastName;
                    student.StudentUserName = item.StudentUserName;
                    student.Password = item.Password;
                    student.Repassword = item.Repassword;
                    student.StudentGender = item.StudentGender;
                    student.StudentDebt = item.StudentDebt;
                    return true;
                }
            }
            return false;
        }     
        public static List<EntityStudent> LLStudentList()
        {
            return DALStudent.StudentList();
        }
    }
}
