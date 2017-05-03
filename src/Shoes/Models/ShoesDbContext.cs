using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace Shoes.Models
{
    public class ShoesDbContext : DbContext
    {
        public ShoesDbContext()
        {

        }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Sale> Sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Shoes;integrated security=True");
        }

        public ShoesDbContext(DbContextOptions<ShoesDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
