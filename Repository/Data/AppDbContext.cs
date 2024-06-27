using Domain.Configurations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repository.Data
{
    public  class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Group> Groups { get; set; }


        public DbSet<Student> Students { get; set; }


        public DbSet<GroupStudent> GroupStudents { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
