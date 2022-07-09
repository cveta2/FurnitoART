using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.Emails
{
    public interface IEmailSender
    {
        void sendEmail(EmailMessage email);
    }
}
