using System;
using RestSharp;

namespace OneCloudNet.Helpers
{
    partial class RequestHelper
    {
        #region Servers

        public RestRequest CreateGetDomainsRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/dns";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        public IRestRequest CreateGetDomainRequest(Int32 domainID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/dns/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", domainID, ParameterType.UrlSegment);
            return request;
        }

        public IRestRequest CreateCreateDomainRequest(String name)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("Name", name);
            return request;
        }

        public IRestRequest CreateDeleteDomainRequest(Int32 domainID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/dns/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", domainID, ParameterType.UrlSegment);
            return request;
        }

        public IRestRequest CreateCreateARecordRequest(Int32 domainID, String ip, String name)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recorda";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("IP", ip);
            request.AddParameter("Name", name);
            return request;
        }

        public IRestRequest CreateCreateAAAARecordRequest(Int32 domainID, String ip, String name)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recordaaaa";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("IP", ip);
            request.AddParameter("Name", name);
            return request;
        }

        public IRestRequest CreateCreateCNAMERecordRequest(Int32 domainID, String name, String mnemonicName)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recordcname";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("Name", name);
            request.AddParameter("MnemonicName", mnemonicName);
            return request;
        }

        public IRestRequest CreateCreateMXRecordRequest(Int32 domainID, String hostName, String priority)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recordmx";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("HostName", hostName);
            request.AddParameter("Priority", priority);
            return request;
        }

        public IRestRequest CreateCreateNSRecordRequest(Int32 domainID, String name)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recordns";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("Name", name);
            return request;
        }

        public IRestRequest CreateCreateTXTRecordRequest(Int32 domainID, String hostName, String text)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/dns/recordtxt";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("DomainId", domainID);
            request.AddParameter("HostName", hostName);
            request.AddParameter("Text", text);
            return request;
        }

        public IRestRequest CreateDeleteRecordRequest(Int32 domainID, Int32 recordID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/dns/{domainid}/{recordId}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("domainid", domainID, ParameterType.UrlSegment);
            request.AddParameter("recordId", recordID, ParameterType.UrlSegment);
            return request;
        }
        
        #endregion
    }
}
