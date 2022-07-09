using ASPProject.Domain;
using ASPProjekat.DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProjekat.DataAccess
{
    public class ProjekatContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            modelBuilder.Entity<ProductSpecification>().HasKey(x => x.Id);
            modelBuilder.Entity<RoleUseCase>().HasKey(x => new { x.RoleId, x.UseCaseId });
            modelBuilder.Entity<ProductSpecification>().Property(x => x.SpecificationValue).IsRequired();
            modelBuilder.Entity<OrderItem>().Property(x => x.Quantity).IsRequired();

            modelBuilder.SetInitialData();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AFNK3Q3\\SQLEXPRESS;Initial Catalog=ASPProject;Integrated Security=True")
                .UseLazyLoadingProxies();
        }

        public override int SaveChanges()
        {
            foreach (var entry in this.ChangeTracker.Entries())
            {
                if (entry.Entity is Entity e)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            e.IsActive = true;
                            e.CreatedAt = DateTime.UtcNow;
                            break;
                        case EntityState.Modified:
                            e.UpdatedAt = DateTime.UtcNow;
                            break;
                        case EntityState.Deleted:
                            e.DeletedAt = DateTime.UtcNow;
                            e.IsActive = false;
                            entry.State = EntityState.Modified;
                            break;
                    }
                }
            }
            return base.SaveChanges();
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSpecification> ProductSpecifications { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleUseCase> RoleUseCases { get; set; }
        public DbSet<ExceptionLog> ExceptionLogs { get; set; }
    }
}
