namespace OneCloudNet.Helpers
{
    using RestSharp;

    /// <summary>
    /// Helper class for creating OneCloudNet RestSharp Requests
    /// </summary>
    internal partial class RequestHelper
    {
        #region Fields

        private readonly string _token;

        #endregion

        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestHelper" /> class.
        /// </summary>
        /// <param name="token">Secret API token.</param>
        internal RequestHelper(string token)
        {
            _token = token;
        }

        #endregion

        #region Images

        internal RestRequest CreateGetImagesRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/image";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        internal RestRequest CreateCreateImageRequest(string name, string techName, int serverID)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/image";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Name", name);
            request.AddParameter("TechName", techName);
            request.AddParameter("ServerID", serverID);

            return request;
        }

        internal RestRequest CreateDeleteImageRequest(int imageID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/image/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", imageID, ParameterType.UrlSegment);
            return request;
        }

        #endregion

        #region DC

        internal IRestRequest CreateGetDCsRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/dcLocation";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        #endregion

        #region SSHKey

        internal RestRequest CreateGetSSHKeysRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/sshkey";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        internal IRestRequest CreateGetSSHKeyRequest(int keyID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/sshkey/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", keyID, ParameterType.UrlSegment);
            return request;
        }

        internal IRestRequest CreateCreateSSHKeyRequest(string title, string publicKey)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Title", title);
            request.AddParameter("PublicKey", publicKey);
            return request;
        }

        internal IRestRequest CreateDeleteSSHKeyRequest(int keyID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/server/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", keyID, ParameterType.UrlSegment);
            return request;
        }

        #endregion

        #region Customer

        internal IRestRequest CreateBalanceRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/customer/balance";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        #endregion

        #region Account

        internal IRestRequest CreateGetAccountRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/account";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        #endregion
    }
}
