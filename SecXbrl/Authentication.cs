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
  
    public class SecXbrlAuth
    {

        public LoginResponse Login(string secXbrlHost, string email, string password)
        {
            ApiInvoker invoker = new ApiInvoker();
            
            var queryParams = new Dictionary<String, String>();

            queryParams.Add("email", email);
            queryParams.Add("password", password);

            ApiResponse response = invoker.InvokeAPI(secXbrlHost, GetEnumDescription(AuthEndPoints.Login), "POST", queryParams, null, new Dictionary<string, string>());

            LoginResponse loginResponse = (LoginResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(LoginResponse));
            loginResponse.RawApiRequest = response.RawApiRequest;
            loginResponse.RawApiResponse = response.RawApiResponse;

            return loginResponse;
        }

        public LogoutResponse Logout(string secXbrlHost, string token)
        {
            ApiInvoker invoker = new ApiInvoker();
            var queryParams = new Dictionary<String, String>();
            queryParams.Add("token", token);
            ApiResponse response = invoker.InvokeAPI(secXbrlHost, GetEnumDescription(AuthEndPoints.Logout), "POST", queryParams, null, new Dictionary<string, string>());

            LogoutResponse logoutResponse = (LogoutResponse)JsonConvert.DeserializeObject(response.RawApiResponse, typeof(LogoutResponse));
            logoutResponse.RawApiRequest = response.RawApiRequest;
            logoutResponse.RawApiResponse = response.RawApiResponse;

            return logoutResponse;
        }



        #region Private Methods

        private static String GetEnumDescription(Enum e)
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
