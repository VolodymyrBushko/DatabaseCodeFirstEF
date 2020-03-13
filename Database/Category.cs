using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VolodCodeFirstEF.Database
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}