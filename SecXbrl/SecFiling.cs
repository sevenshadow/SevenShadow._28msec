using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow._28msec.SecXbrl
{
    public class SecFiling
    {
        public string EntityRegistrantName { get; set; }
        public string AccessionNumber { get; set; }
        public string CIK { get; set; }
        public int FiscalYear { get; set; }
        public string FormType { get; set; }
        public string FiscalPeriod { get; set; }
        public List<SecFilingComponent> Components { get; set; }
       
        
    }
}
