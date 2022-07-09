using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.DTOs
{
    public class ImageDto
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Alt { get; set; }
        public int ProductId { get; set; }
    }
}
