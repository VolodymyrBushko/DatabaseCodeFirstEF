using System.ComponentModel.DataAnnotations;

namespace VolodCodeFirstEF.Database
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int Price { get; set; }
        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}