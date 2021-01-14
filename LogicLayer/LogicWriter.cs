using System.Collections.Generic;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicWriter
    {
        // Logic Layer ana form üzerinden erişilen bir katmandır ve gerekli mantıksal kontrollerin katman olarak geçer 
        // Gerekli kontrolleri başarılı bir şekilde geçen Logic Methodlar Data Access Layerdan uygun methodu çağırarak programın çalışmasına devam edilir
        public static int LLWriterSave(EntityWriter writer)
        {
            if (writer.writerName != "" && writer.writerLastName != "" && writer.writerBirth != "" && writer.writerDeath != "" && writer.writerGender != "")
            {
                return DALWriter.WriterSave(writer);
            }
            else
            {
                return -1;
            }
        }      
        public static bool LLWriterUpdate(EntityWriter writer)
        {
            if (writer.writerName != "" && writer.writerLastName != "" && writer.writerBirth != "" && writer.writerDeath != "" && writer.writerGender != "")
            {
                return DALWriter.WriterUpdate(writer);
            }
            else
            {
                return false;
            }

        }   
        public static bool LLWriterDelete(int writerid)
        {
            if (writerid >= 1)
            {
                return DALWriter.WriterDelete(writerid);
            }
            else
            {
                return false;
            }

        }
        public static List<EntityWriter> LLWriterList()
        {
            return DALWriter.WriterList();
        }
    }
}
