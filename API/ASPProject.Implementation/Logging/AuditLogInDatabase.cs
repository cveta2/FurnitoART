using ASPProject.Application.UseCases;
using ASPProject.Domain;
using ASPProjekat.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.Logging
{
    public class AuditLogInDatabase : IUseCaseLogger
    {
        private readonly ProjekatContext _context;
        public AuditLogInDatabase(ProjekatContext context)
        {
            _context = context;        
        }
        public void Log(UseCaseLog log)
        {
            _context.AuditLogs.Add(new AuditLog 
            { 
                UseCaseName = log.UseCaseName,
                UserId = log.UserId,
                Data = log.Data,
                Date = log.Date,
                IsAuthorized = log.IsAuthorized
            });
            _context.SaveChanges();
        }
    }
}
