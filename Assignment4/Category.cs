using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Assignment4
{
    public class Category
    {

        public Category (string name, string description)
        {
            Name = name;
            Description = Description;
        }
        public Category()
        {
        }

        [Column("categoryId")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
