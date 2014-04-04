using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Web;

namespace SevenShadow._28msec
{
    public class ApiInvoker
    {
        private static readonly ApiInvoker _instance = new ApiInvoker();
        private Dictionary<String, String> defaultHeaderMap = new Dictionary<String, String>();

        public static ApiInvoker GetInstance()
        {
            return _instance;
        }

        public void addDefaultHeader(string key, string value)
        {
            defaultHeaderMap.Add(key, value);
        }

        public static object deserialize(string json, Type type)
        {
            try
            {
                return JsonConvert.DeserializeObject(json, type);
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }

        }

        public static string serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public ApiResponse InvokeAPI(string host, string path, string method, Dictionary<String, String> queryParams, object body, Dictionary<String, String> headerParams)
        {
            ApiResponse apiResponse = new ApiResponse();

            var queryParamStringBuilder = new StringBuilder();

            foreach (var queryParamItem in queryParams)
            {
                var value = queryParamItem.Value;
                if (value == null) continue;
                queryParamStringBuilder.Append(queryParamStringBuilder.ToString().Length == 0 ? "" : "&");
                queryParamStringBuilder.Append(HttpUtility.UrlEncode(queryParamItem.Key)).Append("=").Append(HttpUtility.UrlEncode(value));
            }

            var querystring = (path.IndexOf("?") < 0 ? "?" : "&") + queryParamStringBuilder.ToString();
            
            host = host.EndsWith("/") ? host.Substring(0, host.Length - 1) : host;

            apiResponse.RawApiRequest = host + path + querystring;

            var client = WebRequest.Create(apiResponse.RawApiRequest);
            client.ContentType = "application/json";

            foreach (var headerParamsItem in headerParams)
            {
                client.Headers.Add(headerParamsItem.Key, headerParamsItem.Value);
            }
            foreach (var defaultHeaderMapItem in defaultHeaderMap.Where(defaultHeaderMapItem => !headerParams.ContainsKey(defaultHeaderMapItem.Key)))
            {
                client.Headers.Add(defaultHeaderMapItem.Key, defaultHeaderMapItem.Value);
            }

            switch (method)
            {
                case "GET":
                    break;
                case "POST":
                    break;
                case "PUT":
                    break;
                case "DELETE":
                    if (body != null)
                    {
                        var swRequestWriter = new StreamWriter(client.GetRequestStream());
                        swRequestWriter.Write(serialize(body));
                        swRequestWriter.Close();
                    }
                    break;
                default:
                    throw new ApiException(500, "unknown method type " + method);
            }
         
            client.Method = method;

            HttpWebResponse webResponse;

            try
            {
                webResponse = (HttpWebResponse)client.GetResponse();
                
                if (webResponse.StatusCode != HttpStatusCode.OK &&
                    webResponse.StatusCode != HttpStatusCode.Created &&
                    webResponse.StatusCode != HttpStatusCode.NoContent)
                {
                    apiResponse.ApiException =  new ApiException((int)webResponse.StatusCode, webResponse.StatusDescription);
                    apiResponse.success = false;
                }
                else
                {
                    var responseReader = new StreamReader(webResponse.GetResponseStream());
                    apiResponse.RawApiResponse = responseReader.ReadToEnd();
                    responseReader.Close();
                    apiResponse.success = true;

                }
            }
            catch (Exception e)
            {
                apiResponse.ApiException = new ApiException(0, e.Message);
                apiResponse.success = false;
            }
            
            return apiResponse;
        }
    }
}

