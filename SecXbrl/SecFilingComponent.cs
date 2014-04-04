using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow._28msec.SecXbrl
{
    public class SecFilingComponent
    {
        public string Disclosure { get; set; }
        public string NetworkLabel { get; set; }
        public string AccessionNumber { get; set; }
        public string ComponentId { get; set; }
        public List<FactTableItem> FactTable { get; set; }
        
    }
}
