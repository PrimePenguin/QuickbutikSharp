using System.Net;

namespace QuickbutikSharp.Infrastructure
{
    /// <summary>
    /// An exception thrown when an API call has reached QuickbutikSharp's rate limit.
    /// </summary>
    public class QuickbutikRateLimitException : QuickbutikException
    {
        public QuickbutikRateLimitException()
        { }

        public QuickbutikRateLimitException(string message) : base(message) { }

        public QuickbutikRateLimitException(HttpStatusCode httpStatusCode, string message, int code, string error) : base(httpStatusCode, message, code, error) { }
    }
}