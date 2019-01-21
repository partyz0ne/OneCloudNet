namespace OneCloudNet.Helpers
{
    using System.Collections.Generic;
    using RestSharp;

    /// <summary>
    /// Helper class for creating OneCloudNet RestSharp Requests. Servers part.
    /// </summary>
    internal partial class RequestHelper
    {
        internal RestRequest CreateGetServersRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/server";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        internal IRestRequest CreateGetServerRequest(int serverID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/server/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            return request;
        }

        internal IRestRequest CreateCreateServerRequest(string name, int cpu, int ram, int hdd, string imageID, string hddType, bool isHighPerformance, string dcLocation, bool isBackupActive, int backupPeriod, List<int> sshKeys, int? networkID = null, int? networkBandwidth = null, bool? isNeedSysprep = null)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Name", name);
            CheckServerParams(ref cpu, ref ram, ref hdd);
            request.AddParameter("CPU", cpu);
            request.AddParameter("RAM", ram);
            request.AddParameter("HDD", hdd);
            if (networkID != null)
            {
                request.AddParameter("NetworkID", networkID);
            }

            if (networkBandwidth != null)
            {
                request.AddParameter("NetworkBandwidth", networkBandwidth);
            }

            request.AddParameter("ImageID", imageID);
            request.AddParameter("HDDType", hddType);
            request.AddParameter("isHighPerformance", isHighPerformance);
            request.AddParameter("DCLocation", dcLocation);
            request.AddParameter("isBackupActive", isBackupActive);
            request.AddParameter("BackupPeriod", backupPeriod);
            request.AddParameter("SshKeys", sshKeys);
            if (isNeedSysprep != null)
            {
                request.AddParameter("IsNeedSysprep", isNeedSysprep);
            }

            return request;
        }

        internal IRestRequest CreateChangeServerRequest(int serverID, int cpu, int ram, int hdd, string hddType, bool isHighPerformance)
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

        internal IRestRequest CreateDeleteServerRequest(int serverID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/server/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            return request;
        }

        internal IRestRequest CreateCopyServerRequest(int serverID, string name, int networkID)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server/{id}/copy";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("Name", name);
            request.AddParameter("NetworkId", networkID);
            return request;
        }

        internal IRestRequest CreateRebuildServerRequest(int serverID, int imageID, bool? isNeedSysprep = null)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server/{id}/rebuild";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("ImageId", imageID);
            if (isNeedSysprep != null)
            {
                request.AddParameter("IsNeedSysprep", isNeedSysprep);
            }

            return request;
        }

        internal IRestRequest CreatePowerServerRequest(int serverID, string type)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server/{id}/action";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("Type", type);
            return request;
        }

        internal IRestRequest CreateServerNetworkRequest(int serverID, string type, int networkID)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server/{id}/action";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("Type", type);
            request.AddParameter("NetworkID", networkID);
            return request;
        }

        internal IRestRequest CreateServerNetworkBandwidthRequest(int serverID, string type, int networkLinkID)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/server/{id}/action";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            request.AddParameter("Type", type);
            request.AddParameter("NetworkLinkID", networkLinkID);
            return request;
        }

        internal IRestRequest CreateGetActionsRequest(int serverID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/server/{id}/action";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", serverID, ParameterType.UrlSegment);
            return request;
        }

        internal IRestRequest CreateGetActionRequest(int serverID, int actionID)
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
    }
}
