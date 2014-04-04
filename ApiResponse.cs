using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow._28msec
{
    public class ApiResponse : IResponse 
    {
        public string RawApiRequest { get; set; }
        public string RawApiResponse { get; set; }
        public bool success { get; set; }
        public ApiException ApiException { get; set; }
    }
}
