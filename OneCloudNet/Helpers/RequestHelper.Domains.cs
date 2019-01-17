namespace OneCloudNet.Helpers
{
    using RestSharp;

    internal partial class RequestHelper
    {
        #region Servers

        internal RestRequest CreateGetDomainsRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/dns";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        internal IRestRequest CreateGetDomainRequest(int domainID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/dns/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", domainID, ParameterType.UrlSegment);
            return request;
        }

        internal IRestRequest CreateCreateDomainRequest(string name)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Name", name);
            return request;
        }

        internal IRestRequest CreateDeleteDomainRequest(int domainID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/dns/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", domainID, ParameterType.UrlSegment);
            return request;
        }

        internal IRestRequest CreateCreateARecordRequest(int domainID, string ip, string name, string ttl)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recorda";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("IP", ip);
            request.AddParameter("Name", name);
            request.AddParameter("TTL", ttl);
            return request;
        }

        internal IRestRequest CreateCreateAAAARecordRequest(int domainID, string ip, string name, string ttl)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recordaaaa";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("IP", ip);
            request.AddParameter("Name", name);
            request.AddParameter("TTL", ttl);
            return request;
        }

        internal IRestRequest CreateCreateCNAMERecordRequest(int domainID, string name, string mnemonicName, string ttl)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recordcname";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("Name", name);
            request.AddParameter("MnemonicName", mnemonicName);
            request.AddParameter("TTL", ttl);
            return request;
        }

        internal IRestRequest CreateCreateMXRecordRequest(int domainID, string hostname, string priority, string ttl)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recordmx";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("HostName", hostname);
            request.AddParameter("Priority", priority);
            request.AddParameter("TTL", ttl);
            return request;
        }

        internal IRestRequest CreateCreateNSRecordRequest(int domainID, string hostname, string name, string ttl)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recordns";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("HostName", hostname);
            request.AddParameter("Name", name);
            request.AddParameter("TTL", ttl);
            return request;
        }

        internal IRestRequest CreateCreateTXTRecordRequest(int domainID, string hostName, string text, string ttl)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recordtxt";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("HostName", hostName);
            request.AddParameter("Text", text);
            request.AddParameter("TTL", ttl);
            return request;
        }

        internal IRestRequest CreateDeleteRecordRequest(int domainID, int recordID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/dns/{domainid}/{recordId}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("domainid", domainID, ParameterType.UrlSegment);
            request.AddParameter("recordId", recordID, ParameterType.UrlSegment);
            return request;
        }

        internal IRestRequest CreateCreateSRVRecordRequest(int domainID, string service, string proto, string name, string priority, string weight, string port, string target, string ttl)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recordtxt";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("Service", service);
            request.AddParameter("Proto", proto);
            request.AddParameter("Name", name);
            request.AddParameter("Priority", priority);
            request.AddParameter("Weight", weight);
            request.AddParameter("Port", port);
            request.AddParameter("Target", target);
            request.AddParameter("TTL", ttl);
            return request;
        }

        #endregion
    }
}
