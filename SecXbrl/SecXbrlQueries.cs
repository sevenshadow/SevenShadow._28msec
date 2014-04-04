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
        private ApiInvoker _invoker;

        public SecXbrlQueries()
        {
            _invoker = new ApiInvoker();

        }

        #region Entity Queries

        public EntityResponse GetIndexEntities(string secXbrlHost, EntityGroup entityGroup,  string token = "")
        {
            return this.GetEntities(secXbrlHost, token, GetEnumDescription(entityGroup));
        }

        public EntityResponse GetEntities(string secXbrlHost, string token, string tag)
        {
            ApiInvoker invoker = new ApiInvoker();
            
            var queryParams = new Dictionary<String, String>();

            queryParams.Add("token", token);
            queryParams.Add("tag", tag);

            ApiResponse response = invoker.InvokeAPI(secXbrlHost, GetEnumDescription(QueryEndPoints.Entities), "POST", queryParams, null, new Dictionary<string, string>());

            EntityResponse entityResponse = (EntityResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(EntityResponse));
            entityResponse.RawApiResponse = response.RawApiResponse;
            entityResponse.RawApiRequest = response.RawApiRequest;

            return entityResponse;
        }

        public EntityResponse GetEntitiesByCIK(string secXbrlHost, string token, string cik)
        {
            ApiInvoker invoker = new ApiInvoker();

            var queryParams = new Dictionary<String, String>();

            queryParams.Add("token", token);
            queryParams.Add("cik", cik);

            ApiResponse response = invoker.InvokeAPI(secXbrlHost, GetEnumDescription(QueryEndPoints.Entities), "POST", queryParams, null, new Dictionary<string, string>());

            EntityResponse entityResponse = (EntityResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(EntityResponse));
            entityResponse.RawApiResponse = response.RawApiResponse;
            entityResponse.RawApiRequest = response.RawApiRequest;

            return entityResponse;
        }

        public EntityResponse GetEntitiesByTicker(string secXbrlHost, string token, string ticker)
        {
            ApiInvoker invoker = new ApiInvoker();

            var queryParams = new Dictionary<String, String>();

            queryParams.Add("token", token);
            queryParams.Add("ticker", ticker);

            ApiResponse response = invoker.InvokeAPI(secXbrlHost, GetEnumDescription(QueryEndPoints.Entities), "POST", queryParams, null, new Dictionary<string, string>());

            EntityResponse entityResponse = (EntityResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(EntityResponse));
            entityResponse.RawApiResponse = response.RawApiResponse;
            entityResponse.RawApiRequest = response.RawApiRequest;
            return entityResponse;
        }

        #endregion

        #region Filings Queries

        public FilingResponse GetFilings(FilingRequest request)
        {
            ApiInvoker invoker = new ApiInvoker();

            ApiResponse response = invoker.InvokeAPI(request.SecXbrlHost, GetEnumDescription(QueryEndPoints.Filings), "POST", 
                request.QueryParams, null, new Dictionary<string, string>());

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
        
            ApiResponse response = invoker.InvokeAPI(request.SecXbrlHost, GetEnumDescription(QueryEndPoints.Components), "POST", request.QueryParams, null, new Dictionary<string, string>());

            ComponentResponse filingResponse = (ComponentResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(ComponentResponse));
            filingResponse.RawApiResponse = response.RawApiResponse;
            filingResponse.RawApiRequest = response.RawApiRequest;

            return filingResponse;
        }

        public ComponentResponse GetFactTableForComponent(string secXbrlHost, string componentId, string token = "", Format format = Format.Json)
        {
            ApiInvoker invoker = new ApiInvoker();

            var queryParams = new Dictionary<String, String>();

            if (token != "")
                queryParams.Add("token", token);

            queryParams.Add("cid", componentId);
            queryParams.Add("format", SecXbrlQueries.GetEnumDescription(format));

            ApiResponse response = invoker.InvokeAPI(secXbrlHost, GetEnumDescription(QueryEndPoints.FactableForComponent), "POST", queryParams, null, new Dictionary<string, string>());

            ComponentResponse componentResponse = (ComponentResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(ComponentResponse));
            componentResponse.RawApiResponse = response.RawApiResponse;
            componentResponse.RawApiRequest = response.RawApiRequest;

            return componentResponse;
        }

        public ComponentResponse GetFactTableForComponent(string secXbrlHost, string accessionNumber, string disclosure, string token = "", Format format = Format.Json)
        {
            ApiInvoker invoker = new ApiInvoker();

            var queryParams = new Dictionary<String, String>();

            if (token != "")
                queryParams.Add("token", token);

            queryParams.Add("aid", accessionNumber);
            queryParams.Add("disclosure", disclosure);
            queryParams.Add("format", SecXbrlQueries.GetEnumDescription(format));

            ApiResponse response = invoker.InvokeAPI(secXbrlHost, GetEnumDescription(QueryEndPoints.FactableForComponent), "POST", queryParams, null, new Dictionary<string, string>());

            ComponentResponse componentResponse = (ComponentResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(ComponentResponse));
            componentResponse.RawApiResponse = response.RawApiResponse;
            componentResponse.RawApiRequest = response.RawApiRequest;

            return componentResponse;
        }

        public ComponentResponse GetFactTableForComponent(string secXbrlHost, string cik, int fiscalYear, string fiscalPeriod, string disclosure, string token = "", Format format = Format.Json)
        {
            ApiInvoker invoker = new ApiInvoker();

            var queryParams = new Dictionary<String, String>();

            if (token != "")
                queryParams.Add("token", token);

            queryParams.Add("cik", cik);
            queryParams.Add("fiscalYear", fiscalYear.ToString());
            queryParams.Add("fiscalPeriod", fiscalPeriod);
            queryParams.Add("disclosure", disclosure);
            queryParams.Add("format", SecXbrlQueries.GetEnumDescription(format));

            ApiResponse response = invoker.InvokeAPI(secXbrlHost, GetEnumDescription(QueryEndPoints.FactableForComponent), "POST", queryParams, null, new Dictionary<string, string>());

            ComponentResponse componentResponse = (ComponentResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(ComponentResponse));
            componentResponse.RawApiResponse = response.RawApiResponse;
            componentResponse.RawApiRequest = response.RawApiRequest;

            return componentResponse;
        }

        public ComponentModelResponse GetModelStructureForComponent(string secXbrlHost, string componentId, string token = "", Format format = Format.Json)
        {
            ApiInvoker invoker = new ApiInvoker();

            var queryParams = new Dictionary<String, String>();

            if (token != "")
                queryParams.Add("token", token);

            queryParams.Add("cid", componentId);
            queryParams.Add("format", SecXbrlQueries.GetEnumDescription(format));

            ApiResponse response = invoker.InvokeAPI(secXbrlHost, GetEnumDescription(QueryEndPoints.ModelStructureForComponent), "POST", queryParams, null, new Dictionary<string, string>());

            ComponentModelResponse modelResponse = (ComponentModelResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(ComponentModelResponse));
            modelResponse.RawApiResponse = response.RawApiResponse;
            modelResponse.RawApiRequest = response.RawApiRequest;

            return modelResponse;
        }

        public ComponentModelResponse GetModelStructureForComponent(string secXbrlHost, string accessionNumber, string disclosure, string token = "", Format format = Format.Json)
        {
            ApiInvoker invoker = new ApiInvoker();

            var queryParams = new Dictionary<String, String>();

            if (token != "")
                queryParams.Add("token", token);

            queryParams.Add("aid", accessionNumber);
            queryParams.Add("disclosure", disclosure);
            queryParams.Add("format", SecXbrlQueries.GetEnumDescription(format));

            ApiResponse response = invoker.InvokeAPI(secXbrlHost, GetEnumDescription(QueryEndPoints.ModelStructureForComponent), "POST", queryParams, null, new Dictionary<string, string>());

            ComponentModelResponse modelResponse = (ComponentModelResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(ComponentModelResponse));
            modelResponse.RawApiResponse = response.RawApiResponse;
            modelResponse.RawApiRequest = response.RawApiRequest;

            return modelResponse;
        }

        public ComponentModelResponse GetModelStructureForComponent(string secXbrlHost, string cik, int fiscalYear, string fiscalPeriod, string disclosure, string token = "", Format format = Format.Json)
        {
            ApiInvoker invoker = new ApiInvoker();

            var queryParams = new Dictionary<String, String>();

            if (token != "")
                queryParams.Add("token", token);

            queryParams.Add("cik", cik);
            queryParams.Add("fiscalYear", fiscalYear.ToString());
            queryParams.Add("fiscalPeriod", fiscalPeriod);
            queryParams.Add("disclosure", disclosure);
            queryParams.Add("format", SecXbrlQueries.GetEnumDescription(format));

            ApiResponse response = invoker.InvokeAPI(secXbrlHost, GetEnumDescription(QueryEndPoints.ModelStructureForComponent), "POST", queryParams, null, new Dictionary<string, string>());

            ComponentModelResponse modelResponse = (ComponentModelResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(ComponentModelResponse));
            modelResponse.RawApiResponse = response.RawApiResponse;
            modelResponse.RawApiRequest = response.RawApiRequest;

            return modelResponse;
        }

        public FactResponse GetFacts(FactRequest request)
        {
            ApiInvoker invoker = new ApiInvoker();

            ApiResponse response = invoker.InvokeAPI(request.SecXbrlHost, GetEnumDescription(QueryEndPoints.Facts), "POST", request.QueryParams, null, new Dictionary<string, string>());

            FactResponse modelResponse = (FactResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(FactResponse));
            modelResponse.RawApiResponse = response.RawApiResponse;
            modelResponse.RawApiRequest = response.RawApiRequest;

            return modelResponse;
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
