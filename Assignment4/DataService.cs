using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Assignment4.Operations;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Clauses;

namespace Assignment4
{
    public class DataService : IDataService
    {
        private static NorthwindContext db = new NorthwindContext();

        public static void Main(string[] args)
        {
            //string p = ProductOperations.GetProduct(db, 1).ToString();
            //Debug.WriteLine(p);
        }

        public List<Category> GetCategories()
        {
            return CategoryOperations.GetCategories(db);
        }

        public dynamic GetCategory(int id)
        {
            return CategoryOperations.GetCategory(db, id);
        }

        public dynamic CreateCategory(string name, string description)
        {
            return CategoryOperations.AddCategory(db, name, description);
        }

        public dynamic DeleteCategory(int id)
        {
            return CategoryOperations.DeleteCategory(db, id);
        }

        public dynamic UpdateCategory(int id, string name, string description)
        {
            return CategoryOperations.UpdateCategory(db, id, name, description);
        }

        public Product GetProduct(int id)
        {
            return ProductOperations.GetProduct(db, id);
        }

        public List<Product> GetProductByName(string name)
        {
            return ProductOperations.GetProductsBySubstring(db, name);
        }

        public List<Product> GetProductByCategory(int category)
        {
            return ProductOperations.GetProductsByCategoryId(db, category);
        }

        public Order GetOrder(int id)
        {
            return OrderOperations.GetOrderById(db, id);
        }

        public List<Order> GetOrders()
        {
            return OrderOperations.GetAllOrders(db);
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(int id)
        {
            return OrderDetailsOperations.GetOrderDetails(db, id);
        }

        public List<OrderDetail> GetOrderDetailsByProductId(int id)
        {
            return OrderDetailsOperations.GetProductDetails(db, id);
        }
    }
}
