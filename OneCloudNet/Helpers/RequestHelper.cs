using System;
using RestSharp;

namespace OneCloudNet.Helpers
{
    /// <summary>
    /// Helper class for creating OneCloudNet RestSharp Requests
    /// </summary>
    public class RequestHelper
    {
        private readonly String _token;

        public RequestHelper(String token)
        {
            _token = token;
        }

        public RestRequest CreateGetImagesRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/Image";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

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

        public IRestRequest CreateCreateServerRequest(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Name", name);
            request.AddParameter("CPU", cpu);
            request.AddParameter("RAM", ram);
            request.AddParameter("HDD", hdd);
            request.AddParameter("ImageID", imageID);
            return request;
        }

        public IRestRequest CreateChangeServerRequest(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd)
        {
            var request = new RestRequest(Method.PUT);
            request.Resource = "/server/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("CPU", cpu);
            request.AddParameter("RAM", ram);
            request.AddParameter("HDD", hdd);
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
            var request = new RestRequest(Method.PUT);
            request.Resource = "/server/{id}/action";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("Type", type);
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
    }
}
