using Automarket.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Automarket.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Calor> calors { get; set; }
        /// <summary>
        /// метод дублирует метод из класса стартап, настроить можно и здесь и там
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.LogTo(Console.WriteLine);
            //optionsBuilder.UseSqlServer(connectionString);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Car>().HasKey(e => e.Id);
        //    modelBuilder.Entity<Calor>().HasKey(e => e.Id);
        //    modelBuilder.Entity<Calor>().HasOne(calor => calor.Car)
        //        .WithOne(x => x.Calor).HasForeignKey<Car>(b => b.CalorId);
        //}
    }
}
