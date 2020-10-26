using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Auto_Degree_Map.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseInstance> CourseInstances { get; set; }
        public DbSet<SemesterPlan> SemesterPlan { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet <SemesterPlan> SemesterPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasMany(city => city.Connections)
                           .WithRequired().HasForeignKey(con => con.EndCityId);
        }

    }
}