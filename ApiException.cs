using Newtonsoft.Json;
using System;
using System.Net;

namespace SevenShadow._28msec {
    public class ApiException : WebException
    {

        private int _errorCode = 0;
        private ErrorMessage _errorMessage;
        
        public int ErrorCode
        {
            get
            {
                return _errorCode;
            }
        }
        public ErrorMessage ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
        }

        #region Constructors

        public ApiException() { }
        
        public ApiException(int errorCode, string message)
            : base(message)
        {
            this._errorCode = errorCode;

            if (!String.IsNullOrEmpty(message))
            {
                if (message.StartsWith("{"))
                {
                    _errorMessage = (ErrorMessage)JsonConvert.DeserializeObject(message, typeof(ErrorMessage));
                }
            }

        }

        #endregion
    }

    public class ErrorMessage
    {
        public string request_id { get; set; }
        public string context { get; set; }
        public string description { get; set; }
        public string message { get; set; }
    }
}
