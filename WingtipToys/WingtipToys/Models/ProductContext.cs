using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WingtipToys.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
          : base(ConnectionString)
        {
            //this.SetCommandTimeOut(30);
        }

        public void SetCommandTimeOut(int Timeout)
        {
            var objectContext = (this as IObjectContextAdapter).ObjectContext;
            objectContext.CommandTimeout = Timeout;
        }

        public static string ConnectionString
        {
            get
            {
                try
                {
                    CFEnvironmentVariables _env = new CFEnvironmentVariables(ServerConfig.Configuration);
                    var _connect = _env.getConnectionStringForDbService("user-provided", "wingtiptoysdb");
                    if (!string.IsNullOrEmpty(_connect))
                    {
                        Console.WriteLine($"Using connection string '{_connect}' for catalog");
                        return _connect;
                    }
                }
                catch { }

                var _s = System.Configuration.ConfigurationManager.ConnectionStrings["WingtipToys"].ConnectionString;
                Console.WriteLine($"Using default connection string for catalog {_s}");

                return _s;
            }
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}