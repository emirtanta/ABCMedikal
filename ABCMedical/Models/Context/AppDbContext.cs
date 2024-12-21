using ABCMedical.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ABCMedical.Models.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Log> Logs { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Örnek veriler
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1, CustomerName = "Uğur Çam", Budget = 25000, CustomerType = EnumCustomerType.Standart, TotalSpent = 1200 },
                new Customer { CustomerID = 2, CustomerName = "Cem Can", Budget = 30000, CustomerType = EnumCustomerType.Standart, TotalSpent = 2000 },
                new Customer { CustomerID = 3, CustomerName = "Ali Veli", Budget = 4000, CustomerType = EnumCustomerType.Standart, TotalSpent = 1500 },
                new Customer { CustomerID = 4, CustomerName = "Kazım Okka", Budget = 15000, CustomerType = EnumCustomerType.Premium, TotalSpent = 500 },
                new Customer { CustomerID = 5, CustomerName = "Cemil Şükür", Budget = 100000, CustomerType = EnumCustomerType.Premium, TotalSpent = 150000 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, ProductName = "Laptop", Stock = 50, Price = 50000 },
                new Product { ProductID = 2, ProductName = "IPhone 16 Plus", Stock = 100, Price = 90000 },
                new Product { ProductID = 3, ProductName = "Swatch Saat", Stock = 100, Price = 5500 },
                new Product { ProductID = 4, ProductName = "Logitech Mouse", Stock = 100, Price = 500 },
                new Product { ProductID = 5, ProductName = "Hp Yazıcı", Stock = 100, Price = 6000 },
                new Product { ProductID = 6, ProductName = "Arçelik Buzdolabı", Stock = 100, Price = 10000 }
            );
        }
    }
}
