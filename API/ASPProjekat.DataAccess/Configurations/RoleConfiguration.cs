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
    public class RoleConfiguration : EntityConfiguration<Role>
    {
        protected override void ConfigureRules(EntityTypeBuilder<Role> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.HasMany(x => x.Users)
                    .WithOne(x => x.Role)
                    .HasForeignKey(x => x.RoleId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.RoleUseCases)
                    .WithOne(x => x.Role)
                    .HasForeignKey(x => x.RoleId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
