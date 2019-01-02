using North.Models.Entities;
using System.Data.Entity;

namespace North.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyCon")
        {
            
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
