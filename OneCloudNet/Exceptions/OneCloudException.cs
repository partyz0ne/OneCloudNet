namespace OneCloudNet.Exceptions
{
    using System;
    using System.Linq;
    using System.Net;
    using RestSharp;

    /// <summary>
    /// Common 1Cloud API exception.
    /// </summary>
    [Serializable]
    public class OneCloudException : Exception
    {
        /// <inheritdoc cref="Exception" />
        public OneCloudException()
        {
        }

        /// <inheritdoc cref="Exception" />
        public OneCloudException(string message) 
            : base(message)
        {
        }
    }

    /// <summary>
    /// REST related 1Cloud API exception.
    /// </summary>
    [Serializable]
    public class OneCloudRestException : OneCloudException
    {
        /// <inheritdoc cref="Exception" />
        public OneCloudRestException()
        {
        }

        /// <inheritdoc cref="Exception" />
        public OneCloudRestException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Creates a OneCloudRestException with the rest response which caused the exception, and the status codes which were expected. 
        /// </summary>
        /// <param name="r">Rest Response which was not expected.</param>
        /// <param name="expectedCodes">The expected status codes which were not found.</param>
        public OneCloudRestException(IRestResponse r, params HttpStatusCode[] expectedCodes)
        {
            Response = r;
            StatusCode = r.StatusCode;
            ExpectedCodes = expectedCodes;
        }

        /// <summary>
        /// Returned status code from the request
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Expected status codes to have seen instead of the one recieved. 
        /// </summary>
        public HttpStatusCode[] ExpectedCodes { get; private set; }

        /// <summary>
        /// The response of the error call (for Debugging use)
        /// </summary>
        public IRestResponse Response { get; private set; }

        /// <summary>
        /// Overridden message for 1Cloud Exception. 
        /// <returns>
        /// The exception message in the format of "Received Response [{0}] : Expected to see [{1}]. The HTTP response was [{2}].
        /// </returns>
        /// </summary>
        public override string Message
        {
            get
            {
                return string.Format(
                    "Received Response [{0}] : Expected to see [{1}]. The HTTP response was [{2}].", 
                    Response.StatusCode,
                    string.Join(", ", ExpectedCodes.Select(code => Enum.GetName(typeof(HttpStatusCode), code))),
                    Response.Content);
            }
        }
    }
}
