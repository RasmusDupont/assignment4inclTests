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
            unitPrice = UnitPrice;
            categoryName = CategoryName;
        }

        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string CategoryName { get; set; }
    }
}
