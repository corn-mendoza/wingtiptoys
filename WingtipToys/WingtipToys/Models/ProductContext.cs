using System;
using System.Data.Entity;
namespace WingtipToys.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
          : base(ConnectionString)
        {
        }

        public static string ConnectionString
        {
            get
            {
                CFEnvironmentVariables _env = new CFEnvironmentVariables(ServerConfig.Configuration);
                var _connect = _env.getConnectionStringForDbService("user-provided", "wingtiptoysdb");
                if (_connect != null)
                {
                    Console.WriteLine($"Using connection string '{_connect}' for catalog");
                    return _connect;
                }

                Console.WriteLine($"Using default connection string for cataglog");

                return "WingtipToys";
            }
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}