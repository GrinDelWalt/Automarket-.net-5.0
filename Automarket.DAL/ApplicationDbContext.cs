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
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
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
            modelBuilder.Entity<Image>(builder => 
            {
                builder.ToTable("Image")
                       .HasKey(x=> x.Id);
                builder.HasOne(x => x.Car)
                       .WithMany(x=> x.Images)
                       .HasForeignKey(x=> x.CarId);
            });
            modelBuilder.Entity<Color>(builder =>
            {
                builder.ToTable("Color")
                       .HasKey(x => x.Id);
                builder.HasOne(x => x.Car)
                       .WithOne(x => x.Color)
                       .HasForeignKey<Color>(x => x.CarId);
            });
                

            modelBuilder.Entity<Car>(builder =>
            {
                builder.ToTable("Car").HasKey(x => x.Id);
            });

            

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

            modelBuilder.Entity<Profile>(builder =>
            {
                builder.ToTable("Profiles").HasKey(x => x.Id);

                builder.Property(x => x.Id).ValueGeneratedOnAdd();
                builder.Property(x => x.Age);
                builder.Property(x => x.Address).HasMaxLength(200).IsRequired(false);

                builder.HasData(new Profile()
                {
                    Id = 1,
                    UserId = 1
                });
            });

            modelBuilder.Entity<Basket>(builder =>
            {
                builder.ToTable("Baskets").HasKey(x => x.Id);

                builder.HasData(new Basket()
                {
                    Id = 1,
                    UserId = 1
                });
            });

            modelBuilder.Entity<Order>(builder =>
            {
                builder.ToTable("Orders").HasKey(x => x.Id);

                builder.HasOne(r => r.Basket)
                       .WithMany(t => t.Orders)
                       .HasForeignKey(r => r.BasketId);
            });
        }
    }
}
