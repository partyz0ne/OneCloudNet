using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        #endregion
    }
}
