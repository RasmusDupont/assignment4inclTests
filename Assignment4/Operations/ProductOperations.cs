using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Assignment4.Operations
{
    class ProductOperations
    {
        //6. Get a single product by ID
        public static Product GetProduct(NorthwindContext db, int id)
        {
            Product product = db.Products
                .Where(x => x.Id == id)
                .Include(c => c.Category).
                FirstOrDefault();

            return product;
        }

        //7. Get a list of products that contains a substring
        public static List<Product> GetProductsBySubstring(NorthwindContext db, string sub)
        {
            List<Product> products = db.Products
                .Where(x => x.Name.Contains(sub))
                .Include(c => c.Category)
                .Select(s => new Product
                {
                    Name = s.Name,
                    Category = new Category
                    {
                        Name = s.Category.Name
                    }
                })
                .ToList();

            return products;
        }

        //8. Get products by category ID
        public static List<Product> GetProductsByCategoryId(NorthwindContext db, int id)
        {
            List<Product> products = db.Products
                .Where(x => x.Category.Id == id)
                .Select(s => new Product
                {
                    Name = s.Name,
                    Category = new Category
                    {
                        Name = s.Category.Name
                    }
                })
                .ToList();

            return products;
        }
    }
}
