namespace OneCloudNet.Helpers
{
    using RestSharp;

    internal partial class RequestHelper
    {
        #region Private networks

        internal RestRequest CreateGetPrivateNetworksRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/network";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        internal IRestRequest CreateGetPrivateNetworkRequest(int networkID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/network/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", networkID, ParameterType.UrlSegment);
            return request;
        }

        internal IRestRequest CreateCreatePrivateNetworkRequest(string name)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/network";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Name", name);
            return request;
        }

        internal IRestRequest CreateDeletePrivateNetworkRequest(int networkID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/network/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", networkID, ParameterType.UrlSegment);
            return request;
        }

        internal IRestRequest CreateEditPrivateNetworkRequest(int networkID, string name)
        {
            var request = new RestRequest(Method.PUT);
            request.Resource = "/network/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", networkID, ParameterType.UrlSegment);
            request.AddParameter("Name", name);
            return request;
        }

        #endregion

        #region Public networks

        internal RestRequest CreateGetPublicNetworksRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/publicnetwork";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        internal RestRequest CreateGetPublicNetworkRequest(int networkID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/publicnetwork/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", networkID, ParameterType.UrlSegment);

            return request;
        }

        internal RestRequest CreateOrderPublicNetworkRequest(int networkCapacity, string name, int bandwidth, string dcLocation)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/publicnetwork";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("NetworkCapacity", networkCapacity);
            request.AddParameter("Name", name);
            request.AddParameter("Bandwidth", bandwidth);
            request.AddParameter("DCLocation", dcLocation);

            return request;
        }

        internal RestRequest CreateEditPublicNetworkRequest(int networkID, int bandwidth, string name)
        {
            var request = new RestRequest(Method.PUT);
            request.Resource = "/publicnetwork/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", networkID, ParameterType.UrlSegment);
            request.AddParameter("Bandwidth", bandwidth);
            request.AddParameter("Name", name);

            return request;
        }

        internal RestRequest CreateDeletePublicNetworkRequest(int networkID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/publicnetwork/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", networkID, ParameterType.UrlSegment);

            return request;
        }

        #endregion
    }
}
