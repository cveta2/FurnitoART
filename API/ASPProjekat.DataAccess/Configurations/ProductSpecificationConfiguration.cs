using ASPProject.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProjekat.DataAccess.Configurations
{
    public class ProductSpecificationConfiguration : EntityConfiguration<ProductSpecification>
    {
        protected override void ConfigureRules(EntityTypeBuilder<ProductSpecification> builder)
        {
            
        }
    }
}
