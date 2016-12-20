using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Location.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Location.API.Data
{
    public class LocationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Follow> Follows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("ConnectionDefault");
           
        }
    }
}
