namespace VolodCodeFirstEF.Database
{
    using System.Data.Entity;

    public class MyModel : DbContext
    {
        public MyModel()
            : base("MyModel")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}