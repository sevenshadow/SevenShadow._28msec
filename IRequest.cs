using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow._28msec
{
    public interface IRequest
    {
        string SecXbrlHost { get; set; }
        string Token { get; set; }
        Format Format { get; set; }
    }
}
