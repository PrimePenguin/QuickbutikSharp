using System;
using System.Net;
using Newtonsoft.Json;

namespace QuickbutikSharp.Infrastructure
{
    public class QuickbutikException : Exception
    {
        [JsonIgnore]
        public HttpStatusCode HttpStatusCode { get; set; }

        /// <summary>
        /// The message field is intended for you, the developer, and shouldn't be displayed to an end-user or client. The message field will typically contain detailed debug information.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// Error
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        public QuickbutikException() { }

        public QuickbutikException(string message) : base(message) { }

        public QuickbutikException(HttpStatusCode httpStatusCode, string message, int code, string error) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            Message = message;
            Code = code;
            Error = error;
        }
    }
}