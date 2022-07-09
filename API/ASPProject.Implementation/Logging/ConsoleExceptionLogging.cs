using ASPProject.Application.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.Logging
{
    public class ConsoleExceptionLogging : IExceptionLogger
    {
        public void Log(Exception exception)
        {
            Console.WriteLine("Error occured: " + exception.Message);
        }
    }
}
