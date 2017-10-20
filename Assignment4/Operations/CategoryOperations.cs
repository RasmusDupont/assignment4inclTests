using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Assignment4.Operations
{
    class CategoryOperations
    {
        //9. Get category by ID
        public static dynamic GetCategory(NorthwindContext db, int id)
        {
            var category = db.Categories.FirstOrDefault(x => x.Id == id);

            if (category != null)
            {
                return category;
            }
            else
            {
                return null;
            }
        }

        //10. Get all categories
        public static dynamic GetCategories(NorthwindContext db)
        {
            var categories = db.Categories.ToList();

            return categories;
        }

        //11. Add new category
        public static dynamic AddCategory(NorthwindContext db, string name, string description)
        {
            var category = new Category { Name = name, Description = description };
            db.Categories.Add(category);
            db.SaveChanges();

            return category;
        }

        //12. Update category
        public static bool UpdateCategory(NorthwindContext db, int id, string name, string description)
        {
                var category = db.Categories.FirstOrDefault(x => x.Id == id);
                if (category != null)
                {
                    category.Name = name;
                    category.Description = description;
                    db.SaveChanges();
                    return true;
                }

            return false;
        }

        //13. Delete category
        public static dynamic DeleteCategory(NorthwindContext db, int id)
        {
            try
            {
                var category = db.Categories.FirstOrDefault(x => x.Id == id);
                db.Categories.Remove(category);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
