using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenShadow._28msec;

namespace SevenShadow._28msec.SecXbrl
{
    
    public class EntityRequest : IRequest
    {
        public HttpVerb HttpVerb { get; set; }
        public Format Format { get; set; }
        public string[] Tag { get; set; }
        public string[] CIK { get; set; }
        public string[] Ticker { get; set; }
        public string Token { get; set; }
        
        public string SecXbrlHost { get; set; }
        public object Body { get; set; }
        public Dictionary<string, string> HeaderParams { get; set; }

        public EntityRequest()
            : base()
        {
            Format = SecXbrlQueries.DefaultFormat;
            Body = null;
            HeaderParams = new Dictionary<string, string>();
            HttpVerb = SecXbrlQueries.DefaultHttpVerb;
            Tag = new string[] { };
            CIK = new string[] { };
            Ticker = new string[] { };

        }
        
        public Dictionary<string, string> QueryParams
        {
            get
            {
                var queryParams = new Dictionary<String, String>();
                queryParams.Add("format", SecXbrlQueries.GetEnumDescription(this.Format));

                if (!string.IsNullOrEmpty(Token)) 
                    queryParams.Add("token", this.Token);

                if (this.CIK.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("cik", string.Join(",",this.CIK));

                if (this.Ticker.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("ticker", string.Join(",", this.Ticker));


                if (this.Tag.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("tag", string.Join(",", this.Tag));

                return queryParams;
            }
        }

    }

    public class FilingRequest : IRequest
    {
        public HttpVerb HttpVerb { get; set; }
        public Format Format { get; set; }
        public string[] Tag { get; set; }
        public string[] CIK { get; set; }
        public string[] Ticker { get; set; }
        public string[] FiscalYear { get; set; }
        public string[] FiscalPeriod { get; set; }
        public string Token { get; set; }
        
        public string SecXbrlHost { get; set; }
        public object Body { get; set; }
        public Dictionary<string, string> HeaderParams { get; set; }

        public FilingRequest()
            : base()
        {
            Format = SecXbrlQueries.DefaultFormat;
            Body = null;
            HeaderParams = new Dictionary<string, string>();
            HttpVerb = SecXbrlQueries.DefaultHttpVerb;
            Tag = new string[] { };
            CIK = new string[] { };
            Ticker = new string[] { };
            FiscalYear = new string[] { };
            FiscalPeriod = new string[] { };

        }

        public Dictionary<string, string> QueryParams
        {
            get
            {
                var queryParams = new Dictionary<String, String>();
                queryParams.Add("format", SecXbrlQueries.GetEnumDescription(this.Format));

                if (!string.IsNullOrEmpty(Token))
                    queryParams.Add("token", this.Token);

                if (this.CIK.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("cik", string.Join(",", this.CIK));

                if (this.Ticker.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("ticker", string.Join(",", this.Ticker));

                if (this.FiscalYear.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalYear", string.Join(",", this.FiscalYear));

                if (this.FiscalPeriod.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalPeriod", string.Join(",", this.FiscalPeriod));
                
                if (this.Tag.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("tag", string.Join(",", this.Tag));

                return queryParams;
                
            }
        }

       
    }

    public class ComponentRequest : IRequest
    {
        public HttpVerb HttpVerb { get; set; }
        
        public Format Format { get; set; }
        public string[] Ticker { get; set; }
        public string[] Tag { get; set; }
        public string[] SIC { get; set; }
        public string[] CIK { get; set; }
        public string[] FiscalYear { get; set; }
        public string[] FiscalPeriod { get; set; }
        public string[] AID { get; set; }
        public string[] CID { get; set; }
        public string[] Disclosure { get; set; }
        public string[] ReportElement { get; set; }
        public string Token { get; set; }
        
        public string SecXbrlHost { get; set; }
        public object Body { get; set; }
        public Dictionary<string, string> HeaderParams { get; set; }

        public ComponentRequest()
        {
            Format = SecXbrlQueries.DefaultFormat;
            Body = null;
            HeaderParams = new Dictionary<string, string>();
            HttpVerb = SecXbrlQueries.DefaultHttpVerb;
            Ticker = new string[] { };
            Tag = new string[] { };
            SIC = new string[] { };
            CIK = new string[] { };
            FiscalYear = new string[] { };
            FiscalPeriod = new string[] { };
            AID = new string[] { };
            CID = new string[] { };
            Disclosure = new string[] { };
            ReportElement = new string[] { };
       
        }

        public Dictionary<string, string> QueryParams
        {
            get
            {
                var queryParams = new Dictionary<String, String>();
                queryParams.Add("format", SecXbrlQueries.GetEnumDescription(this.Format));

                if (!string.IsNullOrEmpty(Token))
                    queryParams.Add("token", this.Token);

                if (this.Ticker.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("ticker", string.Join(",", this.Ticker));

                if (this.Tag.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("tag", string.Join(",", this.Tag));
                if (this.SIC.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("sic", string.Join(",", this.SIC));
                if (this.CIK.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("cik", string.Join(",", this.CIK));
                if (this.FiscalYear.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalYear", string.Join(",", this.FiscalYear));

                if (this.FiscalPeriod.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalPeriod", string.Join(",", this.FiscalPeriod));

                if (this.AID.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("aid", string.Join(",", this.AID));

                if (this.CID.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("cid", string.Join(",", this.CID));
                if (this.Disclosure.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("disclosure", string.Join(",", this.Disclosure));

                if (this.ReportElement.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("reportElement", string.Join(",", this.ReportElement));
        
                return queryParams;

            }
        }

    }

    public class ComponentDetailRequest : IRequest
    {
        public HttpVerb HttpVerb { get; set; }
        public Format Format { get; set; }
        public string[] AID { get; set; }
        public string[] CID { get; set; }
        public string[] CIK { get; set; }
        public string[] FiscalYear { get; set; }
        public string[] FiscalPeriod { get; set; }
        public string[] Disclosure { get; set; }
        public string Token { get; set; }
       
        public string SecXbrlHost { get; set; }
        public object Body { get; set; }
        public Dictionary<string, string> HeaderParams { get; set; }

        public ComponentDetailRequest()
        {
            Format = SecXbrlQueries.DefaultFormat;
            Body = null;
            HeaderParams = new Dictionary<string, string>();
            HttpVerb = SecXbrlQueries.DefaultHttpVerb;
            AID = new string[] { };
            CID = new string[] { };
            CIK = new string[] { };
            FiscalYear = new string[] { };
            FiscalPeriod = new string[] { };
            Disclosure = new string[] { };
       
        }

        public Dictionary<string, string> QueryParams
        {
            get
            {
                var queryParams = new Dictionary<String, String>();
                queryParams.Add("format", SecXbrlQueries.GetEnumDescription(this.Format));

                if (!string.IsNullOrEmpty(Token))
                    queryParams.Add("token", this.Token);

                if (this.CIK.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("cik", string.Join(",", this.CIK));
                if (this.FiscalYear.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalYear", string.Join(",", this.FiscalYear));

                if (this.FiscalPeriod.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalPeriod", string.Join(",", this.FiscalPeriod));

                if (this.AID.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("aid", string.Join(",", this.AID));

                if (this.CID.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("cid", string.Join(",", this.CID));
                if (this.Disclosure.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("disclosure", string.Join(",", this.Disclosure));

                
                return queryParams;

            }
        }

    }

    public class FactRequest : IRequest
    {
        public Format Format { get; set; }
        public string[] CIK { get; set; }
        public string[] Ticker { get; set; }
        public string[] Tag { get; set; }
        public string[] SIC { get; set; }
        public string[] FiscalYear { get; set; }
        public string[] FiscalPeriod { get; set; }

        public string Concept { get; set; }

        public HttpVerb HttpVerb { get; set; }
        public string SecXbrlHost { get; set; }
        public string Token { get; set; }
        public string Map { get; set; }
        public string PrefixDimension { get; set; }
        public string PrefixDimensionDefault { get; set; }

        public object Body { get; set; }
        public Dictionary<string, string> HeaderParams { get; set; }

        public FactRequest()
        {
            Format = SecXbrlQueries.DefaultFormat;
            Body = null;
            HeaderParams = new Dictionary<string, string>();
            HttpVerb = SecXbrlQueries.DefaultHttpVerb;
            CIK = new string[] { };
            Ticker = new string[] { };
            Tag = new string[] { };
            SIC = new string[] { };
            FiscalYear = new string[] { };
            FiscalPeriod = new string[] { };
        }

        public Dictionary<string, string> QueryParams
        {
            get
            {
                var queryParams = new Dictionary<String, String>();
                queryParams.Add("format", SecXbrlQueries.GetEnumDescription(this.Format));

                if (this.Token != "")
                    queryParams.Add("token", this.Token);

                if (!string.IsNullOrEmpty(Token))
                    queryParams.Add("token", this.Token);

                if (this.CIK.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("cik", string.Join(",", this.CIK));
                if (this.Ticker.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("ticker", string.Join(",", this.Ticker));
                if (this.Tag.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("tag", string.Join(",", this.Tag));
                if (this.SIC.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("sic", string.Join(",", this.SIC));
                if (this.FiscalYear.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalYear", string.Join(",", this.FiscalYear));
                if (this.FiscalPeriod.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalPeriod", string.Join(",", this.FiscalPeriod));

                if (this.Concept != "")
                    queryParams.Add("concept", this.Concept);
                if (this.Map != "")
                    queryParams.Add("map", this.Map);
                if (this.PrefixDimension != "")
                    queryParams.Add("prefix:dimension", this.PrefixDimension);
                if (this.PrefixDimensionDefault != "")
                    queryParams.Add("prefix:dimension:default", this.PrefixDimensionDefault);

                return queryParams;

            }
        }

    }

    public class FactTableForReportRequest : IRequest
    {
        public Format Format { get; set; }
        public string[] CIK { get; set; }
        public string[] Ticker { get; set; }
        public string[] Tag { get; set; }
        public string[] SIC { get; set; }
        public string[] FiscalYear { get; set; }
        public string[] FiscalPeriod { get; set; }
        public string Report { get; set; }
        public string Token { get; set; }
        
        public HttpVerb HttpVerb { get; set; }
        public string SecXbrlHost { get; set; }
        public object Body { get; set; }
        public Dictionary<string, string> HeaderParams { get; set; }
        
        
        public FactTableForReportRequest()
        {
            Format = SecXbrlQueries.DefaultFormat;
            Body = null;
            HeaderParams = new Dictionary<string, string>();
            HttpVerb = SecXbrlQueries.DefaultHttpVerb;
            CIK = new string[] { };
            Ticker = new string[] { };
            Tag = new string[] { };
            SIC = new string[] { };
            FiscalYear = new string[] { };
            FiscalPeriod = new string[] { };
    
        }

        public Dictionary<string, string> QueryParams
        {
            get
            {
                var queryParams = new Dictionary<String, String>();
                queryParams.Add("format", SecXbrlQueries.GetEnumDescription(this.Format));
                if (this.Token != "")
                    queryParams.Add("token", this.Token);
                if(this.CIK.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("cik", string.Join(",", this.CIK));
                if (this.Ticker.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("ticker", string.Join(",", this.Ticker));
                if (this.Tag.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("tag", string.Join(",", this.Tag));
                if (this.SIC.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("sic", string.Join(",", this.SIC));
                if (this.FiscalYear.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalYear", string.Join(",", this.FiscalYear));
                if (this.FiscalPeriod.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalPeriod", string.Join(",", this.FiscalPeriod));
                
                if (this.Report != "")
                    queryParams.Add("report", this.Report);

                return queryParams;

            }
        }

    }

    public class ReportElementsRequest : IRequest
    {
         public Format Format { get; set; }
         public string[] Tag { get; set; }
         public string[] CIK { get; set; }
        public string[] Ticker { get; set; }
        public string[] SIC { get; set; }
        public string[] FiscalYear { get; set; }
        public string[] FiscalPeriod { get; set; }
        public string[] AID { get; set; }
        public bool OnlyNames { get; set; }
        public string Token { get; set; }
        
        public HttpVerb HttpVerb { get; set; }
        public string SecXbrlHost { get; set; }
        public object Body { get; set; }
        public Dictionary<string, string> HeaderParams { get; set; }


        public ReportElementsRequest()
        {
            Format = SecXbrlQueries.DefaultFormat;
            Body = null;
            HeaderParams = new Dictionary<string, string>();
            HttpVerb = SecXbrlQueries.DefaultHttpVerb;
            Tag = new string[] { };
            CIK = new string[] { };
            Ticker = new string[] { };
            SIC = new string[] { };
            FiscalYear = new string[] { };
            FiscalPeriod = new string[] { };
            AID = new string[] { };


        }

        public Dictionary<string, string> QueryParams
        {
            get
            {
                var queryParams = new Dictionary<String, String>();
                queryParams.Add("format", SecXbrlQueries.GetEnumDescription(this.Format));
                if (this.Token != "")
                    queryParams.Add("token", this.Token);
                if(this.CIK.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("cik", string.Join(",", this.CIK));
                if (this.Ticker.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("ticker", string.Join(",", this.Ticker));
                if (this.Tag.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("tag", string.Join(",", this.Tag));
                if (this.SIC.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("sic", string.Join(",", this.SIC));
                if (this.FiscalYear.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalYear", string.Join(",", this.FiscalYear));
                if (this.FiscalPeriod.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("fiscalPeriod", string.Join(",", this.FiscalPeriod));
                
               if (this.AID.Any(x => !string.IsNullOrEmpty(x)))
                    queryParams.Add("aid", string.Join(",", this.AID));
               
                queryParams.Add("onlyNames", this.OnlyNames.ToString().ToLower());
                return queryParams;

            }
        }

        

    }
}
