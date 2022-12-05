using Automarket.Domain.Enam;
using Automarket.Domain.Entity;
using Automarket.Domain.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Automarket.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Color> Сolor { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        /// <summary>
        /// метод дублирует метод из класса стартап, настроить можно и здесь и там
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.LogTo(Console.WriteLine);
            //optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasKey(e => e.Id);
            modelBuilder.Entity<Color>().HasKey(e => e.Id);
            modelBuilder.Entity<Color>().HasOne(color => color.Car)
                .WithOne(x => x.Color).HasForeignKey<Car>(b => b.ColorId);
            modelBuilder.Entity<Image>().HasKey(e => e.Id);
            modelBuilder.Entity<Car>().HasMany(e => e.Images).WithOne(x => x.Car);

            modelBuilder.Entity<User>(builder =>
            {
                builder.ToTable("Users").HasKey(x => x.Id);

                builder.HasData(new User
                {
                    Id = 1,
                    Name = "ITHomester",
                    Password = HashPasswordHelper.HashPassword("123456"),
                    Role = Role.Admin
                });

                builder.Property(x => x.Id).ValueGeneratedOnAdd();

                builder.Property(x => x.Password).IsRequired();
                builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

                builder.HasOne(x => x.Profile)
                    .WithOne(x => x.User)
                    .HasPrincipalKey<User>(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);

                builder.HasOne(x => x.Basket)
                    .WithOne(x => x.User)
                    .HasPrincipalKey<User>(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);
            });

        }
    }
}
