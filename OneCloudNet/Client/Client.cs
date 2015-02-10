using System;
using System.Net;
using OneCloudNet.Exceptions;
using OneCloudNet.Helpers;
using RestSharp;
using RestSharp.Deserializers;

namespace OneCloudNet.Client
{
    public partial class OneCloudNetClient : IOneCloudNetClient
    {
        private const String ApiBaseUrl = "https://api.1cloud.ru";

        private readonly String _token;

        private RestClient _restClient;
        private RequestHelper _requestHelper;

        public IWebProxy Proxy { get; set; }

        /// <summary>
        /// Default Constructor for the OneCloudNetClient
        /// </summary>
        /// <param name="token">The token to use for the 1Cloud Requests</param>
        /// <param name="proxy">The proxy to use for web requests</param>
        public OneCloudNetClient(String token, IWebProxy proxy = null)
        {
            Proxy = proxy;
            LoadClient();
            _token = token;
        }

        private void LoadClient()
        {
            _restClient = new RestClient(ApiBaseUrl);
            _restClient.Proxy = Proxy;
            _restClient.ClearHandlers();
            _restClient.AddHandler("*", new JsonDeserializer());

            _requestHelper = new RequestHelper(_token);
        }

        private T Execute<T>(IRestRequest request) where T : new()
        {
            var response = _restClient.Execute<T>(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new OneCloudRestException(response, HttpStatusCode.OK);

            return response.Data;
        }

        private IRestResponse Execute(IRestRequest request)
        {
            var response = _restClient.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new OneCloudRestException(response, HttpStatusCode.OK);

            return response;
        }

        private void ExecuteAsync(IRestRequest request, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            _restClient.ExecuteAsync(request, (response, asynchandle) =>
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    failure(new OneCloudRestException(response, HttpStatusCode.OK));
                }
                else
                {
                    success(response);
                }
            });
        }

        private void ExecuteAsync<T>(IRestRequest request, Action<T> success, Action<OneCloudException> failure)
            where T : new()
        {
            _restClient.ExecuteAsync<T>(request, (response, asynchandle) =>
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    failure(new OneCloudRestException(response, HttpStatusCode.OK));
                }
                else
                {
                    success(response.Data);
                }
            });
        }
    }
}
