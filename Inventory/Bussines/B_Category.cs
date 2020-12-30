using Entities;
using System.Collections.Generic;
using DataAccess;
using System.Linq;

namespace Bussines
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }
        public static CategoryEntity CategoryById(string Id)
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList().LastOrDefault(p => p.CategoryId == Id);
            }
        }
        public static void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }

    }

}
