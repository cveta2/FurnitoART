using ASPProject.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProjekat.DataAccess.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SetInitialData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(InitialData.Roles);
            modelBuilder.Entity<RoleUseCase>().HasData(InitialData.RoleUseCases);
            modelBuilder.Entity<Category>().HasData(InitialData.Categories);
            modelBuilder.Entity<Specification>().HasData(InitialData.Specifications);
            modelBuilder.Entity<User>().HasData(InitialData.Users);
            modelBuilder.Entity<Product>().HasData(InitialData.Products);
            modelBuilder.Entity<Order>().HasData(InitialData.Orders);
            modelBuilder.Entity<OrderItem>().HasData(InitialData.OrderItems);
            modelBuilder.Entity<Cart>().HasData(InitialData.Carts);
            modelBuilder.Entity<Price>().HasData(InitialData.Prices);
            modelBuilder.Entity<ProductSpecification>().HasData(InitialData.ProductSpecifications);
            modelBuilder.Entity<Image>().HasData(InitialData.Images);
            
        }
    }
}
