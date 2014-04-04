using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow._28msec
{
    public interface IResponse
    {
        string RawApiRequest { get; set; }
        string RawApiResponse { get; set; }
        bool success { get; set; }
        ApiException ApiException { get; set; }
    }
}
