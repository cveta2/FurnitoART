using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Domain
{
    public class ExceptionLog
    {
        public int Id { get; set; }
        public DateTime OccuredAt { get; set; }
        public string Message { get; set; }
    }
}
