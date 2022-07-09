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
    public class SpecificationConfiguration : EntityConfiguration<Specification>
    {
        protected override void ConfigureRules(EntityTypeBuilder<Specification> builder)
        {
            builder.Property(x => x.SpecificationName).IsRequired().HasMaxLength(50);

            builder.HasMany(x => x.ProductSpecifications)
                   .WithOne(x => x.Specification)
                   .HasForeignKey(x => x.SpecificationId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
