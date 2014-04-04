using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow._28msec.SecXbrl
{
   
    public class FactTableItem
    {
        public Dictionary<string, string> Aspects { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public int Decimals { get; set; }
        public string Unit { get; set; }
        
    }
}
