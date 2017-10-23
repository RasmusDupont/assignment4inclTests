using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.DTO
{

    public class ProductDTO
    {
        public ProductDTO(string name, double unitPrice, string categoryName)
        {
            Name = name;
            UnitPrice = unitPrice;
            Category = new CategoryNameDTO(categoryName);
        }

        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public CategoryNameDTO Category { get; set; }
    }
}
