using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow._28msec.SecXbrl
{
    public class EntityResponse : IResponse
    {
        public string RawApiRequest { get; set; }
        public string RawApiResponse { get; set; }
        public bool success { get; set; }
        public List<SecEntity> Entities { get; set; }
        public ApiException ApiException { get; set; }
    }

    public class FilingResponse : IResponse
    {
        public string RawApiRequest { get; set; }
        public string RawApiResponse { get; set; }
        public bool success { get; set; }
        public ApiException ApiException { get; set; }
        public string EntityRegistrantName { get; set; }
        public string CIK { get; set; }
        public string FormType { get; set; }
        public string FiscalPeriod { get; set; }

        public List<SecFiling> Archives { get; set; }

    }

    public class ComponentResponse : IResponse
    {
        public string RawApiRequest { get; set; }
        public string RawApiResponse { get; set; }
        public bool success { get; set; }
        public ApiException ApiException { get; set; }

        public string EntityRegistrantName { get; set; }
        public string CIK { get; set; }
        public string FormType { get; set; }
        public string FiscalPeriod { get; set; }
        public string FiscalYear { get; set; }

        public List<SecFiling> Archives { get; set; }
        public List<FactTableItem> FactTable { get; set; }
    }

    public class ComponentModelResponse : IResponse
    {
        public string RawApiRequest { get; set; }
        public string RawApiResponse { get; set; }
        public bool success { get; set; }
        public ApiException ApiException { get; set; }
        public string CIK { get; set; }
        public string EntityRegistrantName { get; set; }
        public string Label { get; set; }
        public string AccessionNumber  { get; set; }
        public string TableName { get; set; }
        public string FormType { get; set; }
        public string FiscalPeriod { get; set; }
        public int FiscalYear { get; set; }
        public DateTime AcceptanceDatetime { get; set; }
        public string NetworkIdentifier { get; set; }
        public string Disclosure { get; set; }
        public string Comment { get; set; }
        public List<ModelStructureNode> ModelStructure { get; set; }
    }

    public class FactResponse : IResponse
    {
        public string RawApiRequest { get; set; }
        public string RawApiResponse { get; set; }
        public bool success { get; set; }
        public ApiException ApiException { get; set; }


        public string NetworkIdentifier { get; set; }
        public string TableName { get; set; }
        public string Comment { get; set; }
        public ResponseStatistics Statistics { get; set; }
        public List<FactTableItem> FactTable { get; set; }
       


    }

    public class ResponseStatistics
    {
        public long NumFacts { get; set; }
        public long TotalNumFacts { get; set; }
        public long TotalNumArchives { get; set; }
        public long TotalNumEntities { get; set; }


    }

}
