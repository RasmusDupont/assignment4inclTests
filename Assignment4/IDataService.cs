using System.Collections.Generic;

namespace Assignment4
{
    public interface IDataService
    {
        dynamic CreateCategory(string name, string description);
        dynamic DeleteCategory(int id);
        List<Category> GetCategories();
        dynamic GetCategory(int id);
        dynamic UpdateCategory(int id, string name, string description);
        Product GetProduct(int id);
        List<Product> GetProductByName(string name);
        List<Product> GetProductByCategory(int category);
    }
}