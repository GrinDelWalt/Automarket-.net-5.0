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
        public DbSet<Color> Сolor { get; set; }
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
        //    modelBuilder.Entity<Color>().HasKey(e => e.Id);
        //    modelBuilder.Entity<Color>().HasOne(color => color.Car)
        //        .WithOne(x => x.Color).HasForeignKey<Car>(b => b.ColorId);
        //}
    }
}
