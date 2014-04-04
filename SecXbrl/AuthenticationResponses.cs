using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow._28msec.SecXbrl
{
    public class LoginResponse : IResponse
    {
        public string RawApiRequest { get; set; }
        public string RawApiResponse { get; set; }
        public bool success { get; set; }
        public ApiException ApiException { get; set; } public string Token { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class LogoutResponse : IResponse
    {
        public string RawApiRequest { get; set; }
        public string RawApiResponse { get; set; }
        public bool success { get; set; }
        public ApiException ApiException { get; set; }
    }
}
