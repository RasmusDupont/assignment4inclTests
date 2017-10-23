using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.DTO
{
    public class CategoryNameDTO
    {
        public CategoryNameDTO(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }

    
}
