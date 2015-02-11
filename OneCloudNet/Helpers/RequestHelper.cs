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
            request.Resource = "/image";
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
            CheckServerParams(ref cpu, ref ram, ref hdd);
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
            CheckServerParams(ref cpu, ref ram, ref hdd);
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
            var request = new RestRequest(Method.POST);
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
    }
}
