namespace OneCloudNet.Exceptions
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using RestSharp;

#pragma warning disable CA1032 // Implement standard exception constructors
#pragma warning disable CA2237 // Mark ISerializable types with serializable
    /// <summary>
    /// Common 1Cloud API exception.
    /// </summary>
    public class OneCloudException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneCloudException" /> class.
        /// </summary>
        public OneCloudException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneCloudException" /> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public OneCloudException(string message)
            : base(message)
        {
        }
    }

    /// <summary>
    /// REST related 1Cloud API exception.
    /// </summary>
    public class OneCloudRestException : OneCloudException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneCloudRestException" /> class.
        /// </summary>
        public OneCloudRestException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneCloudRestException" /> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public OneCloudRestException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneCloudRestException" /> class.
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
        /// Expected status codes to have seen instead of the one received.
        /// </summary>
        public HttpStatusCode[] ExpectedCodes { get; }

        /// <summary>
        /// The response of the error call (for Debugging use)
        /// </summary>
        public IRestResponse Response { get; }

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
                    CultureInfo.InvariantCulture,
                    "Received Response [{0}] : Expected to see [{1}]. The HTTP response was [{2}].",
                    Response.StatusCode,
                    string.Join(", ", ExpectedCodes.Select(code => Enum.GetName(typeof(HttpStatusCode), code))),
                    Response.Content);
            }
        }
    }
#pragma warning restore CA1032 // Implement standard exception constructors
#pragma warning restore CA2237 // Mark ISerializable types with serializable
}
