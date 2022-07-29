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
               new User {  Email = "acompany@gmail.com", Password = "123" },
               new User {  Email = "bcompany@gmail.com", Password = "345"}
               );
            modelBuilder.Entity<UserOperationClaim>().HasData(
                new UserOperationClaim { UserId = 1, OperationClaimId = "Admin" },
                new Role { RoleId = 2, RoleName = "Moderator" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Vegan" },
                new Category { CategoryId = 2, CategoryName = "Meat" },
                new Category { CategoryId = 3, CategoryName = "Breakfast" },
                new Category { CategoryId = 4, CategoryName = "Sea Food" }
                );
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { Id = 1, CategoryId = 1, Title = "Falafel", Detail = Falafel, Image = "https://www.nefissyemektarifleri.com/wp-content/uploads/2018/07/falafel-tarifi.jpg", Ingredients = FalafelIngredients },
                new Recipe { Id = 2, CategoryId = 2, Title = "Steak", Detail = Steak, Image = "https://ozhacibeytepeoren.com/wp-content/uploads/2020/03/Dana-Antrikot-350x200.jpg", Ingredients = SteakIngredients },
                new Recipe { Id = 3, CategoryId = 4, Title = "Fırında Lüfer", Detail = FırındaLufer, Image = "https://www.enpratikbilgiler.com/wp-content/uploads/2020/12/lufer-baligi-nasil-pisirilir-en-kolay-lufer-baligi-pisirme-yontemi-firinda-lufer-tarifi-VBBUiTP9.jpg", Ingredients = FırındaLuferIngredients },
                new Recipe { Id = 4, CategoryId = 3, Title = "Kruvasan", Detail = Kruvasan, Image = "https://cdn.yemek.com/mncrop/940/625/uploads/2014/10/kruvasan-tarifi.jpg", Ingredients = KruvasanIngredients }
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
