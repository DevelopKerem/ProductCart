using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.EntityFramework
{
    public class EfDbContext:DbContext
    { 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-OBH1HV3\\MSSQLSERVER01; database=productcart; Trusted_Connection=true; MultipleActiveResultSets=true");
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Basket> baskets { get; set; }
    }
}
