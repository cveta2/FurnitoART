﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.Emails
{
    public class EmailMessage
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
