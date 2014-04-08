using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel;
using System.Reflection;
using Newtonsoft.Json;

namespace SevenShadow._28msec.SecXbrl
{
 
    public class SecXbrlQueries
    {
        #region Private Variables

        private ApiInvoker _invoker;

        #endregion

        #region Public Static Properties

        public static Format DefaultFormat = Format.Json;
        public static HttpVerb DefaultHttpVerb = HttpVerb.Post;

        #endregion

        #region Contructors

        public SecXbrlQueries()
        {
            _invoker = new ApiInvoker();

        }

        #endregion

        #region Entity Queries

        public EntityResponse GetEntities(EntityRequest request)
        {
            ApiInvoker invoker = new ApiInvoker();
            ApiResponse response = invoker.InvokeAPI(request.SecXbrlHost, GetEnumDescription(QueryEndPoints.Entities), GetEnumDescription(request.HttpVerb), request.QueryParams, request.Body, request.HeaderParams);
            
            if (response.success)
            {
                EntityResponse entityResponse = (EntityResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(EntityResponse));
                entityResponse.RawApiResponse = response.RawApiResponse;
                entityResponse.RawApiRequest = response.RawApiRequest;
                return entityResponse;   
            }
            else
            {
                throw response.ApiException;
            }
        
        }

        public EntityResponse GetEntities(string secXbrlHost, string tag, string token = "")
        {
            EntityRequest request = new EntityRequest();
            request.SecXbrlHost = secXbrlHost;
            request.Tag = new string[] { tag } ;
            request.Token = token;

            return GetEntities(request);
     
        }

        public EntityResponse GetEntitiesByCIK(string secXbrlHost, string cik, string token = "")
        {
            EntityRequest request = new EntityRequest();
            request.SecXbrlHost = secXbrlHost;
            request.CIK = new string[] { cik };
            request.Token = token;

            return GetEntities(request);
        }

        public EntityResponse GetEntitiesByTicker(string secXbrlHost, string ticker, string token = "")
        {
            EntityRequest request = new EntityRequest();
            request.SecXbrlHost = secXbrlHost;
            request.Ticker = new string[] { ticker };
            request.Token = token;

            return GetEntities(request);
        }

        public EntityResponse GetIndexEntities(string secXbrlHost, EntityGroup entityGroup,  string token = "")
        {
            EntityRequest request = new EntityRequest();
            request.SecXbrlHost = secXbrlHost;
            request.Tag = new string[] { GetEnumDescription(entityGroup) };
            request.Token = token;

            return GetEntities(request);
        }
    
        #endregion

        #region Filings Queries

        public FilingResponse GetFilings(FilingRequest request)
        {
            ApiInvoker invoker = new ApiInvoker();

            ApiResponse response = invoker.InvokeAPI(request.SecXbrlHost, GetEnumDescription(QueryEndPoints.Filings), GetEnumDescription(request.HttpVerb),
                request.QueryParams, request.Body, request.HeaderParams);

            if (response.success)
            {
                FilingResponse filingResponse = (FilingResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(FilingResponse));
                filingResponse.RawApiResponse = response.RawApiResponse;
                return filingResponse;
            }
            else
            {
                throw response.ApiException;
            }
        }

        #endregion

        #region Components Queries

        public ComponentResponse GetComponents(ComponentRequest request)
        {
            ApiInvoker invoker = new ApiInvoker();

            var queryParams = new Dictionary<String, String>();

            ApiResponse response = invoker.InvokeAPI(request.SecXbrlHost, GetEnumDescription(QueryEndPoints.Components),
                GetEnumDescription(request.HttpVerb), request.QueryParams, request.Body, request.HeaderParams);

            if (response.success)
            {
                ComponentResponse filingResponse = (ComponentResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(ComponentResponse));
                filingResponse.RawApiResponse = response.RawApiResponse;
                filingResponse.RawApiRequest = response.RawApiRequest;

                return filingResponse;
            }
            else
            {
                throw response.ApiException;
            }
        }

        #endregion

        #region Fact Table for a Component Queries

        public ComponentResponse GetFactTableForComponent(ComponentDetailRequest request)
        {
            ApiInvoker invoker = new ApiInvoker();

            ApiResponse response = invoker.InvokeAPI(request.SecXbrlHost, 
                GetEnumDescription(QueryEndPoints.FactableForComponent),
                GetEnumDescription(request.HttpVerb), request.QueryParams, request.Body, request.HeaderParams);

            if (response.success)
            {
                ComponentResponse componentResponse = (ComponentResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(ComponentResponse));
                componentResponse.RawApiResponse = response.RawApiResponse;
                componentResponse.RawApiRequest = response.RawApiRequest;
                return componentResponse;
            }
            else
            {
                throw response.ApiException;
            }
        }

        public ComponentResponse GetFactTableForComponent(string secXbrlHost, string cid,
           string token = "", Format format = Format.Json)
        {
            ComponentDetailRequest request = new ComponentDetailRequest();
            request.SecXbrlHost = secXbrlHost;
            request.CID = new string[] { cid };
             request.Token = token;
            request.Format = format;

            return GetFactTableForComponent(request);

        }

        public ComponentResponse GetFactTableForComponent(string secXbrlHost, string accessionNumber, string disclosure, 
            string token = "", Format format = Format.Json)
        {
            ComponentDetailRequest request = new ComponentDetailRequest();
            request.SecXbrlHost = secXbrlHost;
            request.AID = new string[] { accessionNumber };
            request.Disclosure = new string[] { disclosure };
            request.Token = token;
            request.Format = format;

            return GetFactTableForComponent(request);
            
        }

        public ComponentResponse GetFactTableForComponent(string secXbrlHost, string cik, string fiscalYear, 
            string fiscalPeriod, string disclosure, string token = "", Format format = Format.Json)
        {
            ComponentDetailRequest request = new ComponentDetailRequest();
            request.SecXbrlHost = secXbrlHost;
            request.CIK = new string[] { cik };
            request.FiscalYear = new string[] { fiscalYear };
            request.FiscalPeriod = new string[] { fiscalPeriod };
            request.Disclosure = new string[] { disclosure };
            request.Token = token;
            request.Format = format;

            return GetFactTableForComponent(request);
         
        }

        #endregion

        #region Model structure for a Component Queries

        public ComponentModelResponse GetModelStructureForComponent(ComponentDetailRequest request)
        {
            ApiInvoker invoker = new ApiInvoker();

            ApiResponse response = invoker.InvokeAPI(request.SecXbrlHost,
                GetEnumDescription(QueryEndPoints.ModelStructureForComponent),
                GetEnumDescription(request.HttpVerb), request.QueryParams, request.Body, request.HeaderParams);

            if (response.success)
            {
                ComponentModelResponse modelResponse = (ComponentModelResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(ComponentModelResponse));
                modelResponse.RawApiResponse = response.RawApiResponse;
                modelResponse.RawApiRequest = response.RawApiRequest;

                return modelResponse;
            }
            else
            {
                throw response.ApiException;
            }
        }

        public ComponentModelResponse GetModelStructureForComponent(string secXbrlHost, string cid, string token = "", Format format = Format.Json)
        {

            ComponentDetailRequest request = new ComponentDetailRequest();
            request.SecXbrlHost = secXbrlHost;
            request.CID = new string[] { cid };
            request.Token = token;
            request.Format = format;

            return GetModelStructureForComponent(request);

        }

        public ComponentModelResponse GetModelStructureForComponent(string secXbrlHost, string aid, string disclosure, 
            string token = "", Format format = Format.Json)
        {
            ComponentDetailRequest request = new ComponentDetailRequest();
            request.SecXbrlHost = secXbrlHost;
            request.AID = new string[] { aid };
            request.Disclosure = new string[] { disclosure };
            request.Token = token;
            request.Format = format;

            return GetModelStructureForComponent(request);
           
        }

        public ComponentModelResponse GetModelStructureForComponent(string secXbrlHost, string cik, 
            string fiscalYear, string fiscalPeriod, string disclosure, string token = "", Format format = Format.Json)
        {
            ComponentDetailRequest request = new ComponentDetailRequest();
            request.SecXbrlHost = secXbrlHost;
            request.CIK = new string[] { cik };
            request.FiscalYear = new string[] { fiscalYear };
            request.FiscalPeriod = new string[] { fiscalPeriod };
            request.Disclosure = new string[] { disclosure };
            request.Token = token;
            request.Format = format;

            return GetModelStructureForComponent(request);
           
        }

        #endregion

        #region Facttable for Report

        public FactResponse GetFactTableForReport(FactTableForReportRequest request)
        {
            ApiInvoker invoker = new ApiInvoker();

            ApiResponse response = invoker.InvokeAPI(request.SecXbrlHost, GetEnumDescription(QueryEndPoints.FactTableForReport), GetEnumDescription(request.HttpVerb),
                request.QueryParams, request.Body, request.HeaderParams);

            if (response.success)
            {
                FactResponse factResponse = (FactResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(FactResponse));
                factResponse.RawApiResponse = response.RawApiResponse;
                factResponse.RawApiRequest = response.RawApiRequest;

                return factResponse;
            }
            else
            {
                throw response.ApiException;
            }
        }

        #endregion

        #region Get Facts Queries

        public FactResponse GetFacts(FactRequest request)
        {
            ApiInvoker invoker = new ApiInvoker();

            ApiResponse response = invoker.InvokeAPI(request.SecXbrlHost, GetEnumDescription(QueryEndPoints.Facts), GetEnumDescription(request.HttpVerb),
                request.QueryParams, request.Body, request.HeaderParams);

            if (response.success)
            {
                FactResponse modelResponse = (FactResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(FactResponse));
                modelResponse.RawApiResponse = response.RawApiResponse;
                modelResponse.RawApiRequest = response.RawApiRequest;

                return modelResponse;
            }
            else
            {
                throw response.ApiException;
            }
        }

        #endregion

        #region Report Elements

        public FactResponse GetReportElements(ReportElementsRequest request)
        {
            ApiInvoker invoker = new ApiInvoker();

            ApiResponse response = invoker.InvokeAPI(request.SecXbrlHost, GetEnumDescription(QueryEndPoints.ReportElements), GetEnumDescription(request.HttpVerb),
                request.QueryParams, request.Body, request.HeaderParams);

            if (response.success)
            {
                FactResponse modelResponse = (FactResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(FactResponse));
                modelResponse.RawApiResponse = response.RawApiResponse;
                modelResponse.RawApiRequest = response.RawApiRequest;

                return modelResponse;
            }
            else
            {
                throw response.ApiException;
            }
        }
        public FactResponse GetReportElements(string secXbrlHost, string aid, string token = "", bool onlyNames = false, Format format = Format.Json)
        {
            ReportElementsRequest request = new ReportElementsRequest();
            request.AID = new string[] { aid };
            request.SecXbrlHost = secXbrlHost;
            request.Token = token;
            request.OnlyNames = onlyNames;
            request.Format = format;

            return GetReportElements(request);
        }

        #endregion

        #region Helper Methods

        public static String GetEnumDescription(Enum e)
        {
            FieldInfo fieldInfo = e.GetType().GetField(e.ToString());

            DescriptionAttribute[] enumAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (enumAttributes.Length > 0)
                return enumAttributes[0].Description;

            return e.ToString();
        }

        #endregion

    }
}
