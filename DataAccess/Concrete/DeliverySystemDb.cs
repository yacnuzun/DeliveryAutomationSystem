using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class DeliverySystemDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DeliveryAutomationSystem;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
               new User { Id=1 ,Email = "acompany@gmail.com", Password = "123" },
               new User { Id=2 ,Email = "bcompany@gmail.com", Password = "345"}
               );
            modelBuilder.Entity<UserOperationClaim>().HasData(
                new UserOperationClaim { UserId = 1, OperationClaimId = 1 },
                new UserOperationClaim { UserId = 1, OperationClaimId = 2 },
                new UserOperationClaim { UserId = 1, OperationClaimId = 3 },
                new UserOperationClaim { UserId = 1, OperationClaimId = 5 },
                new UserOperationClaim { UserId = 2, OperationClaimId = 1 },
                new UserOperationClaim { UserId = 1, OperationClaimId = 4 },
                new UserOperationClaim { UserId = 1, OperationClaimId = 6 },
                new UserOperationClaim { UserId = 1, OperationClaimId = 7 }
                );
            modelBuilder.Entity<OperationClaim>().HasData(
                new OperationClaim { Id=1 ,Name = "GetDelivery" },
                new OperationClaim { Id=2 ,Name = "deliveryenter" },
                new OperationClaim { Id=3 ,Name = "deliveryhandover" },
                new OperationClaim { Id=4 ,Name = "deliverytake" },
                new OperationClaim { Id = 5, Name = "getorder" },
                new OperationClaim { Id = 6, Name = "addproduct" },
                new OperationClaim { Id = 7, Name = "addorder" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId=1,ProductName="Tablet" },
                new Product { ProductId=2,ProductName="Laptop" },
                new Product { ProductId=3,ProductName="Telefon" },
                new Product { ProductId = 4, ProductName = "Hoparlör" }
                );
            modelBuilder.Entity<Delivery>().HasData(
                new Delivery { DeliveryId=1,VehicleNumber = "02A223", DeliveryDate = DateTime.Parse("2022-07-29 14:40:52,531"), CargoMan = "Ahmet", Status = 0 },
                new Delivery { DeliveryId=2,DeliveryDate = DateTime.Parse("2022-07-29 14:40:52,531"), VehicleNumber = "20B2020", CargoMan = "Mehmet", Status = 0 },
                new Delivery { DeliveryId=3,DeliveryDate = DateTime.Parse("2021-07-29 14:40:52,531"), VehicleNumber = "30C234", CargoMan = "Ali", Status = 2 },
                new Delivery { DeliveryId =4, DeliveryDate = DateTime.Parse("2021-07-29 14:40:52,531"), VehicleNumber = "15v3030", CargoMan = "Esra", Status = 2 }
                );
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId= 1,OrderDate = DateTime.Parse("2021-07-29 14:40:52,531"), EndPoint = "Zonguldak", StartPoint = "Bursa", ContactNumber = "" },
                new Order { OrderId = 2, OrderDate = DateTime.Parse("2021-07-29 14:40:52,531"), EndPoint = "Samsun", StartPoint = "İstanbul", ContactNumber = ""},
                new Order { OrderId = 3, OrderDate = DateTime.Parse("2021-07-29 14:40:52,531"), EndPoint = "İstanbul", StartPoint = "İzmir", ContactNumber = ""},
                new Order { OrderId = 4, OrderDate = DateTime.Parse("2021-07-29 14:40:52,531"), EndPoint = "Antalya", StartPoint = "Muğla", ContactNumber = ""}
                );
            modelBuilder.Entity<OrderProduct>().HasData(
                new OrderProduct { OrderId = 1, ProductId = 2, Quantity = 30 },
                new OrderProduct { OrderId = 2, ProductId = 2, Quantity = 20 },
                new OrderProduct { OrderId = 1, ProductId = 2, Quantity = 40 }
                );
        }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OperationClaim> OperationClaims{ get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
