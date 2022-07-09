using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Domain
{
    public class Category : Entity
    {
        public string CategoryName { get; set; }
        public int? ParentCategoryId { get; set; }

        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<Category> ChildCategories { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
