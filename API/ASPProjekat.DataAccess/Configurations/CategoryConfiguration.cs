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
    public class CategoryConfiguration : EntityConfiguration<Category>
    {
        protected override void ConfigureRules(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(100);

            builder.HasIndex(x => x.CategoryName).IsUnique();

            builder.HasMany(x => x.Products)
                   .WithOne(x => x.Category)
                   .HasForeignKey(x => x.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.ChildCategories)
                   .WithOne(x => x.ParentCategory)
                   .HasForeignKey(x => x.ParentCategoryId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
