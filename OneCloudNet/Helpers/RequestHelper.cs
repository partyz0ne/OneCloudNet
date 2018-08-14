namespace OneCloudNet.Helpers
{
    using System;
    using RestSharp;

    /// <summary>
    /// Helper class for creating OneCloudNet RestSharp Requests
    /// </summary>
    public partial class RequestHelper
    {
        #region Fields

        private readonly string _token;

        #endregion

        #region .ctor

        public RequestHelper(string token)
        {
            _token = token;
        }

        #endregion

        #region Images

        public RestRequest CreateGetImagesRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/image";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        public RestRequest CreateCreateImageRequest(string name, string techName, int serverID)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/image";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Name", name);
            request.AddParameter("TechName", techName);
            request.AddParameter("ServerID", serverID);

            return request;
        }

        public RestRequest CreateDeleteImageRequest(int imageID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/image/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", imageID, ParameterType.UrlSegment);
            return request;
        }

        #endregion

        #region Private networks

        public RestRequest CreateGetNetworksRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/network";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        public IRestRequest CreateGetNetworkRequest(int networkID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/network/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", networkID, ParameterType.UrlSegment);
            return request;
        }

        public IRestRequest CreateCreateNetworkRequest(string name)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/network";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Name", name);
            return request;
        }

        public IRestRequest CreateDeleteNetworkRequest(int networkID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/network/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", networkID, ParameterType.UrlSegment);
            return request;
        }

        #endregion

        #region DC

        public IRestRequest CreateGetDCsRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/dcLocation";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        #endregion

        #region SSHKey

        public RestRequest CreateGetSSHKeysRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/sshkey";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        public IRestRequest CreateGetSSHKeyRequest(int keyID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/sshkey/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", keyID, ParameterType.UrlSegment);
            return request;
        }

        public IRestRequest CreateCreateSSHKeyRequest(string title, string publicKey)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Title", title);
            request.AddParameter("PublicKey", publicKey);
            return request;
        }

        public IRestRequest CreateDeleteSSHKeyRequest(int keyID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/server/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", keyID, ParameterType.UrlSegment);
            return request;
        }

        #endregion

        #region Servers

        public RestRequest CreateGetServersRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/server";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        public IRestRequest CreateGetServerRequest(int serverID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/server/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            return request;
        }

        public IRestRequest CreateCreateServerRequest(string name, int cpu, int ram, int hdd, string imageID, string hddType, bool isHighPerformance, string dcLocation)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Name", name);
            CheckServerParams(ref cpu, ref ram, ref hdd);
            request.AddParameter("CPU", cpu);
            request.AddParameter("RAM", ram);
            request.AddParameter("HDD", hdd);
            request.AddParameter("ImageID", imageID);
            request.AddParameter("HDDType", hddType);
            request.AddParameter("isHighPerformance", isHighPerformance);
            request.AddParameter("DCLocation", dcLocation);
            return request;
        }

        public IRestRequest CreateChangeServerRequest(int serverID, int cpu, int ram, int hdd, string hddType, bool isHighPerformance)
        {
            var request = new RestRequest(Method.PUT);
            request.Resource = "/server/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            CheckServerParams(ref cpu, ref ram, ref hdd);
            request.AddParameter("CPU", cpu);
            request.AddParameter("RAM", ram);
            request.AddParameter("HDD", hdd);
            request.AddParameter("HDDType", hddType);
            request.AddParameter("isHighPerformance", isHighPerformance);
            return request;
        }

        public IRestRequest CreateDeleteServerRequest(int serverID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/server/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            return request;
        }

        public IRestRequest CreatePowerServerRequest(int serverID, string type)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server/{id}/action";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("Type", type);
            return request;
        }

        public IRestRequest CreateServerNetworkRequest(int serverID, string type, int? networkID)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server/{id}/action";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("Type", type);
            request.AddParameter("NetworkID", networkID);
            return request;
        }

        public IRestRequest CreateGetActionsRequest(int serverID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/server/{id}/action";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            return request;
        }

        public IRestRequest CreateGetActionRequest(int serverID, int actionID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/server/{id}/action/{actionID}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("actionID", actionID, ParameterType.UrlSegment);
            return request;
        }

        private static void CheckServerParams(ref int cpu, ref int ram, ref int hdd)
        {
            if (cpu < 1)
            {
                cpu = 1;
            }
            else if (cpu > 8)
            {
                cpu = 8;
            }

            if (ram < 512)
            {
                ram = 512;
            }
            else if (ram > 16384)
            {
                ram = 16384;
            }

            if (hdd < 10)
            {
                hdd = 10;
            }
            else if (hdd > 250)
            {
                hdd = 250;
            }
        }

        #endregion

        #region Customer

        public IRestRequest CreateBalanceRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/customer/balance";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        #endregion

        #region Account

        public IRestRequest CreateGetAccountRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/account";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        #endregion

        #region Storages

        public IRestRequest CreateGetStorageRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/storage";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        public IRestRequest CreateActivateStorageRequest()
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/storage";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        public IRestRequest CreateDeactivateStorageRequest()
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/storage";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        #endregion
    }
}
