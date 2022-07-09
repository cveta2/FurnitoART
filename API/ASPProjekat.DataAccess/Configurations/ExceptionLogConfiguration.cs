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
    public class ExceptionLogConfiguration : IEntityTypeConfiguration<ExceptionLog>
    {
        public void Configure(EntityTypeBuilder<ExceptionLog> builder)
        {
            builder.Property(x => x.Message).IsRequired();
            builder.Property(x => x.OccuredAt).HasDefaultValueSql("GETDATE()");
        }
    }
}
