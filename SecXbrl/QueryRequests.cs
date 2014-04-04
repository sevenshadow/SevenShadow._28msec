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
        public string SecXbrlHost { get; set; }
        public string CIK { get; set; }
        public string Token { get; set; }
        public string FiscalYear { get; set; }
        public FiscalPeriod FiscalPeriod { get; set; }
        public Format Format { get; set; }
        public Tag Tag { get; set; }
        public string Ticker { get; set; }

        public EntityRequest()
        {
            this.Tag = Tag.Default;
            this.FiscalPeriod = FiscalPeriod;
        }
        public Dictionary<string, string> QueryParams
        {
            get
            {
                var queryParams = new Dictionary<String, String>();
                if (this.Token != "")
                    queryParams.Add("token", this.Token);

                if (this.CIK != "")
                    queryParams.Add("cik", this.CIK);

                if (this.Ticker != "")
                    queryParams.Add("ticker", this.Ticker);

                if (this.FiscalYear != "")
                    queryParams.Add("fiscalYear", this.FiscalYear);

                if (this.FiscalPeriod != _28msec.FiscalPeriod.FY)
                    queryParams.Add("fiscalPeriod", SecXbrlQueries.GetEnumDescription(this.FiscalPeriod));

                if (this.Format != _28msec.Format.Json)
                    queryParams.Add("format", SecXbrlQueries.GetEnumDescription(this.Format));

                if (this.Tag != _28msec.Tag.Default)
                    queryParams.Add("tag", SecXbrlQueries.GetEnumDescription(this.Tag));

                return queryParams;

            }
        }


    }

    public class FilingRequest : IRequest
    {
        public string SecXbrlHost { get; set; }
        public string CIK { get; set; }
        public string Token { get; set; }
        public string FiscalYear { get; set; }
        public FiscalPeriod FiscalPeriod { get; set; }
        public Format Format { get; set; }
        public Tag Tag { get; set; } 
        public string Ticker { get; set; }

        public FilingRequest()
        {
            this.Tag = Tag.Default;
            this.FiscalPeriod = FiscalPeriod;
        }
        public Dictionary<string, string> QueryParams
        {
            get
            {
                var queryParams = new Dictionary<String, String>();
                if (this.Token != "")
                    queryParams.Add("token", this.Token);
                
                if (this.CIK != "")
                    queryParams.Add("cik", this.CIK);

                if (this.Ticker != "")
                    queryParams.Add("ticker", this.Ticker);

                if (this.FiscalYear != "")
                    queryParams.Add("fiscalYear", this.FiscalYear);
               
                if (this.FiscalPeriod != _28msec.FiscalPeriod.FY)
                    queryParams.Add("fiscalPeriod", SecXbrlQueries.GetEnumDescription(this.FiscalPeriod));

                if (this.Format != _28msec.Format.Json)
                    queryParams.Add("format", SecXbrlQueries.GetEnumDescription(this.Format));

                if (this.Tag != _28msec.Tag.Default)
                    queryParams.Add("tag", SecXbrlQueries.GetEnumDescription(this.Tag));

                return queryParams;

            }
        }

       
    }

    public class ComponentRequest : IRequest
    {
        public string SecXbrlHost { get; set; }
        public string SIC { get; set; }
        public string Token { get; set; }
        public string FiscalYear { get; set; }
        public FiscalPeriod FiscalPeriod { get; set; }
        public Format Format { get; set; }
        public Tag Tag { get; set; }
        public string Ticker { get; set; }
        public string AID { get; set; }
        public string CID { get; set; }

        public string Disclosure { get; set; }
        public string Concept { get; set; }

        public ComponentRequest()
        {
            this.Tag = Tag.Default;
            this.FiscalPeriod = FiscalPeriod;
        }

        public Dictionary<string, string> QueryParams
        {
            get
            {
                var queryParams = new Dictionary<String, String>();
                if (this.Token != "")
                    queryParams.Add("token", this.Token);
                if (this.AID != "")
                    queryParams.Add("aid", this.AID);
                if (this.CID != "")
                    queryParams.Add("cid", this.CID);
                if (this.Disclosure != "")
                    queryParams.Add("disclosure", this.Disclosure);
                if (this.Concept != "")
                    queryParams.Add("concept", this.Concept);

                if (this.SIC != "")
                    queryParams.Add("cik", this.SIC);

                if (this.Ticker != "")
                    queryParams.Add("ticker", this.Ticker);

                if (this.FiscalYear != "")
                    queryParams.Add("fiscalYear", this.FiscalYear);

                if (this.FiscalPeriod != _28msec.FiscalPeriod.FY)
                    queryParams.Add("fiscalPeriod", SecXbrlQueries.GetEnumDescription(this.FiscalPeriod));

                if (this.Format != _28msec.Format.Json)
                    queryParams.Add("format", SecXbrlQueries.GetEnumDescription(this.Format));

                if (this.Tag != _28msec.Tag.Default)
                    queryParams.Add("tag", SecXbrlQueries.GetEnumDescription(this.Tag));

                return queryParams;

            }
        }

    }

    public class FactRequest : IRequest
    {
        public string SecXbrlHost { get; set; }
        public Format Format { get; set; }
        public string Ticker { get; set; }
        
        public string SIC { get; set; }
        public string Token { get; set; }
        public string FiscalYear { get; set; }
        public FiscalPeriod FiscalPeriod { get; set; }
        public Tag Tag { get; set; }
        public string AID { get; set; }
        public string CID { get; set; }

        public string Disclosure { get; set; }
        public string Concept { get; set; }
        public string Map { get; set; }
        public string PrefixDimension { get; set; }
        public string PrefixDimensionDefault { get; set; }

        public FactRequest()
        {
            this.Tag = Tag.Default;
            this.FiscalPeriod = FiscalPeriod;
        }

        public Dictionary<string, string> QueryParams
        {
            get
            {
                var queryParams = new Dictionary<String, String>();
                if (this.Token != "")
                    queryParams.Add("token", this.Token);
                if (this.AID != "")
                    queryParams.Add("aid", this.AID);
                if (this.CID != "")
                    queryParams.Add("cid", this.CID);
                if (this.Disclosure != "")
                    queryParams.Add("disclosure", this.Disclosure);
                if (this.Concept != "")
                    queryParams.Add("concept", this.Concept);

                if (this.SIC != "")
                    queryParams.Add("cik", this.SIC);
                if (this.Map != "")
                    queryParams.Add("map", this.Map);
                if (this.PrefixDimension != "")
                    queryParams.Add("prefix:dimension", this.PrefixDimension);
                if (this.PrefixDimensionDefault != "")
                    queryParams.Add("prefix:dimension:default", this.PrefixDimensionDefault);

                if (this.Ticker != "")
                    queryParams.Add("ticker", this.Ticker);

                if (this.FiscalYear != "")
                    queryParams.Add("fiscalYear", this.FiscalYear);

                if (this.FiscalPeriod != _28msec.FiscalPeriod.FY)
                    queryParams.Add("fiscalPeriod", SecXbrlQueries.GetEnumDescription(this.FiscalPeriod));

                if (this.Format != _28msec.Format.Json)
                    queryParams.Add("format", SecXbrlQueries.GetEnumDescription(this.Format));

                if (this.Tag != _28msec.Tag.Default)
                    queryParams.Add("tag", SecXbrlQueries.GetEnumDescription(this.Tag));

                return queryParams;

            }
        }

    }

}
