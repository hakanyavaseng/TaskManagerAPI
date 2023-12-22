using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Entities;

namespace TaskManager.DataAccess
{
    public class TaskManagerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=HY\\SQLEXPRESS;Database=TaskManager;Trusted_Connection=True;");
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }

      
    }

        
}
