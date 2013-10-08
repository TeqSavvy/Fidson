using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Fidson
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("FidsonDb")
        {
        }

        public DbSet<Product> Products { get; set; }
    }


    [Table("Products")]
    public class Product
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}