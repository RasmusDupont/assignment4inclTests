using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Assignment4
{
    public class Category
    {
        [Column("categoryId")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
