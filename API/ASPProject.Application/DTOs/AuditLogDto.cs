using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.DTOs
{
    public class AuditLogDto
    {
        public int Id { get; set; }
        public string UseCaseName { get; set; }
        public DateTime Date { get; set; }
        public string Data { get; set; }
        public bool IsAuthorized { get; set; }
        public int UserId { get; set; }
    }
}
