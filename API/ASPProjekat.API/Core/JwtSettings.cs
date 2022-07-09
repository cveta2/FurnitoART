using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPProjekat.API.Core
{
    public class JwtSettings
    {
        public string Issuer { get; set; }
        public string SecretKey { get; set; }
        public int Minutes { get; set; }
    }
}
