using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Syra.Models;

namespace Syra.Data
{
    public class SyraContext : DbContext
    {
        public SyraContext(DbContextOptions<SyraContext> options)
            : base(options)
        {
        }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>().ToTable("Resource");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
