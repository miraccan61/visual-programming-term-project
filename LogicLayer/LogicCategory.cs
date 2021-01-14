using System.Collections.Generic;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicCategory
    {
        // Logic Layer ana form üzerinden erişilen bir katmandır ve gerekli mantıksal kontrollerin katman olarak geçer 
        // Gerekli kontrolleri başarılı bir şekilde geçen Logic Methodlar Data Access Layerdan uygun methodu çağırarak programın çalışmasına devam edilir
        public static int LLCategorySave(EntityCategory cat)
        {
            if (cat.categoryName != "")
            {
                //burada sifreyi sifrele
                return DALCategory.CategorySave(cat);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLCategoryUpdate(EntityCategory cat)
        {
            if (cat.categoryName != "")
            {
                return DALCategory.CategoryUpdate(cat);
            }
            else
            {
                return false;
            }
        }   
        public static bool LLCategoryDelete(int cat)
        {
            if (cat >= 1)
            {
                return DALCategory.CategoryDelete(cat);
            }
            else
            {
                return false;
            }
        }    
        public static List<EntityCategory> LLCategoryList()
        {
            return DALCategory.CategoryList();
        }
   
    }
}
