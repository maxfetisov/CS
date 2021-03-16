using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    class CSDBContext:DbContext
    {
        public CSDBContext() : base("Data Source =DESKTOP-PNOODSG\\SQLEXPRESS; Initial Catalog = CommunicationSalon; Integrated Security = True")
        {
            Database.CreateIfNotExists();
        }
        public CSDBContext(string connectionString) : base(connectionString)
        {
            Database.CreateIfNotExists();
        }
        public DbSet<Brand> Brand{ get; set; }
        public DbSet<Consumer> Consumer { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<PhoneNumber> PhoneNumber { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductInOrder> ProductInOrder { get; set; }
        public DbSet<RoleConsumer> RoleConsumers { get; set; }
        public DbSet<Tariff> Tariff { get; set; }
        public DbSet<TypeProduct> TypeProduct { get; set; }
        public DbSet<User> User { get; set; }
    }
}
