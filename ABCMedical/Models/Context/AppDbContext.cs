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
        public DbSet<Cart> Carts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Örnek veriler
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1, CustomerName = "Uğur",CustomerSurname="Çam",Username="ucam",Email="ucam@gmail.com",Password="1", Budget = 25000, CustomerType = EnumCustomerType.Standart, TotalSpent = 1200 },
                new Customer { CustomerID = 2, CustomerName = "Cem", CustomerSurname = "Can", Username = "ccan", Email = "ccan@gmail.com", Password = "1", Budget = 30000, CustomerType = EnumCustomerType.Standart, TotalSpent = 2000 },
                new Customer { CustomerID = 3, CustomerName = "Ali", CustomerSurname = "Veli", Username = "aveli", Email = "aveli@gmail.com", Password = "1", Budget = 4000, CustomerType = EnumCustomerType.Standart, TotalSpent = 1500 },
                new Customer { CustomerID = 4, CustomerName = "Kazım", CustomerSurname = "Okka", Username = "kokka", Email = "kokka@gmail.com", Password = "1", Budget = 15000, CustomerType = EnumCustomerType.Premium, TotalSpent = 500 },
                new Customer { CustomerID = 5, CustomerName = "Cemil", CustomerSurname = "Şükür", Username = "csukur", Email = "csukur@gmail.com", Password = "1", Budget = 100000, CustomerType = EnumCustomerType.Premium, TotalSpent = 150000 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, ProductName = "Laptop", Stock = 50, UnitPrice = 50000 },
                new Product { ProductID = 2, ProductName = "IPhone 16 Plus", Stock = 100, UnitPrice = 90000 },
                new Product { ProductID = 3, ProductName = "Swatch Saat", Stock = 100, UnitPrice = 5500 },
                new Product { ProductID = 4, ProductName = "Logitech Mouse", Stock = 100, UnitPrice = 500 },
                new Product { ProductID = 5, ProductName = "Hp Yazıcı", Stock = 100, UnitPrice = 6000 },
                new Product { ProductID = 6, ProductName = "Arçelik Buzdolabı", Stock = 100, UnitPrice = 10000 }
            );
        }
    }
}
