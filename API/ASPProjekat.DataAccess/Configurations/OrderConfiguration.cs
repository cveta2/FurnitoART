using ASPProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProjekat.DataAccess.Configurations
{
    public class OrderConfiguration : EntityConfiguration<Order>
    {
        protected override void ConfigureRules(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100);
            builder.Property(x => x.City).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(100);

            builder.HasIndex(x => x.OrderNumber).IsUnique();

            builder.HasMany(x => x.OrderItems)
                   .WithOne(x => x.Order)
                   .HasForeignKey(x => x.OrderId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
