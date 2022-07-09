using ASPProject.Application.Logging;
using ASPProject.Domain;
using ASPProjekat.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.Logging
{
    public class EfExceptionLogging : IExceptionLogger
    {
        private readonly ProjekatContext _context;
        public EfExceptionLogging(ProjekatContext context)
        {
            _context = context;
        }
        public void Log(Exception exception)
        {
            _context.ExceptionLogs.Add(new ExceptionLog
            {
                OccuredAt = DateTime.Now,
                Message = exception.Message
            }) ;
            _context.SaveChanges();
        }
    }
}
