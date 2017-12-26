using System;
using RestSharp;

namespace OneCloudNet.Helpers
{
    /// <summary>
    /// Helper class for creating OneCloudNet RestSharp Requests
    /// </summary>
    public partial class RequestHelper
    {
        #region Fields

        private readonly String _token;

        #endregion

        #region .ctor

        public RequestHelper(String token)
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

        public RestRequest CreateCreateImageRequest(String name, String techName, Int32 serverID)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/image";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Name", name);
            request.AddParameter("TechName", techName);
            request.AddParameter("ServerID", serverID);

            return request;
        }

        public RestRequest CreateDeleteImageRequest(Int32 imageID)
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

        public IRestRequest CreateGetNetworkRequest(Int32 networkID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/network/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", networkID, ParameterType.UrlSegment);
            return request;
        }

        public IRestRequest CreateCreateNetworkRequest(String name)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/network";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Name", name);
            return request;
        }

        public IRestRequest CreateDeleteNetworkRequest(Int32 networkID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/network/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", networkID, ParameterType.UrlSegment);
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

        public IRestRequest CreateGetServerRequest(Int32 serverID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/server/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            return request;
        }

        public IRestRequest CreateCreateServerRequest(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID, String hddType, Boolean isHighPerformance, String dcLocation)
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

        public IRestRequest CreateChangeServerRequest(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd, String hddType, Boolean isHighPerformance)
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

        public IRestRequest CreateDeleteServerRequest(Int32 serverID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/server/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            return request;
        }

        public IRestRequest CreatePowerServerRequest(Int32 serverID, String type)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server/{id}/action";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("Type", type);
            return request;
        }

        public IRestRequest CreateServerNetworkRequest(Int32 serverID, String type, Int32? networkID)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server/{id}/action";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("Type", type);
            request.AddParameter("NetworkID", networkID);
            return request;
        }

        public IRestRequest CreateGetActionsRequest(Int32 serverID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/server/{id}/action";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            return request;
        }

        public IRestRequest CreateGetActionRequest(Int32 serverID, Int32 actionID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/server/{id}/action/{actionID}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("actionID", actionID, ParameterType.UrlSegment);
            return request;
        }

        private static void CheckServerParams(ref Int32 cpu, ref Int32 ram, ref Int32 hdd)
        {
            if (cpu < 1)
                cpu = 1;
            else if (cpu > 8)
                cpu = 8;

            if (ram < 512)
                ram = 512;
            else if (ram > 16384)
                ram = 16384;

            if (hdd < 10)
                hdd = 10;
            else if (hdd > 250)
                hdd = 250;
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

        #region DC

        public IRestRequest CreateGetDCsRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/dcLocation";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        #endregion
    }
}
