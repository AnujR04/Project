using Microsoft.EntityFrameworkCore;
using Project.MyProject.DAL;

namespace Project.ProjectService
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Sales> sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();
        }
    }
}
