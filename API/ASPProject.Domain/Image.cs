using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Domain
{
    public class Image : Entity
    {
        public string Path { get; set; }
        public string Alt { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
