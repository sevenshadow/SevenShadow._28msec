using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow._28msec.SecXbrl
{
    public class SecEntity
    {
        public string EntityRegistrantName { get; set; }
        public string AccessionNumber { get; set; }
        public string CIK { get; set; }
        public int FiscalYear { get; set; }
        public string FormType { get; set; }
        public string FiscalPeriod { get; set; }
        public string SIC { get; set; }
        public string SICDescription { get; set; }
        public string SICGroup { get; set; }
        public string Sector { get; set; }
        public string CompanyType { get; set; }
        public string Taxonomy { get; set; }
        public List<string> Tickers { get; set; }
        public Dictionary<string, SecEntityProfile> Profiles { get; set; }
        
    }

    public class SecEntityProfile
    {
        public string CompanyName { get; set; }
        public string AccessionNumber { get; set; }
        public string CIK { get; set; }
        public int FiscalYear { get; set; }
        public string FormType { get; set; }
        public string FiscalPeriod { get; set; }
        public string SIC { get; set; }
        public string SICDescription { get; set; }
        public string SICGroup { get; set; }
        public string Sector { get; set; }
        public string CompanyType { get; set; }
        public string Taxonomy { get; set; }
        public List<string> Tickers { get; set; }

    }
}
