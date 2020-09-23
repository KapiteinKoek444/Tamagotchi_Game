using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entities;

namespace UserService.Database
{
    public class DatabaseContext : DbContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PetAnimal> PetAnimals { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            "Server=mssql.fhict.local;Database=dbi436203;User Id=dbi436203;Password=Mickey_aNnxwmjzST89");
        }
    }
}
