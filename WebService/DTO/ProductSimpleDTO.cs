using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.DTO
{
    public class ProductSimpleDTO
    {
        public ProductSimpleDTO(string name, string categoryName)
        {
            Name = name;
            CategoryName = categoryName;
        }

        public string Name { get; set; }
        public string CategoryName { get; set; }
    }
}
