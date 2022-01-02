using Microsoft.EntityFrameworkCore;
using Paradox.Data.Concrete.EntityFramework.Mappings;
using Paradox.Entities.Concrete;
using Paradox.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Data.Concrete.EntityFramework.Contexts
{
    public class ParadoxContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Catagories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClime> OperationClimes { get; set; }
        public DbSet<UserOperationClimes> UserOperationClimes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ParadoxDatabase.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new OperationClimeMap());
            modelBuilder.ApplyConfiguration(new UserOperationClimesMap());
        }
    }
}
