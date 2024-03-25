using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ComputerStoreDBContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        public ComputerStoreDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-EPIN2RS;User Id=sa;Password=axcitoSQL;Database=ComputerStoreDB;");
        }
    }
}
