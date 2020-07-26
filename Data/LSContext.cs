using LifeScheduler.Models.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeScheduler.Data
{
    public class LSContext : IdentityDbContext<ApplicationUser>
    {
        public LSContext(DbContextOptions<LSContext> options)
            : base(options)
        { }

        
        public DbSet<Arena> Arena { get; set; }
        public DbSet<DastTest> DastTest { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Sport> Sport { get; set; }
        public DbSet<Workout> Workout { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
