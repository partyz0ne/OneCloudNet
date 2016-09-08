using System;
using System.Collections.Generic;
using OneCloudNet.Enums;
using OneCloudNet.Exceptions;
using OneCloudNet.Models;
using Action = OneCloudNet.Models.Action;
using IRestResponse = RestSharp.IRestResponse;

namespace OneCloudNet.Client
{
    public partial class OneCloudNetClient
    {
        #region Customer

        /// <summary>
        /// Get account balance.
        /// </summary>
        /// <returns>Current balance.</returns>
        public void Balance(Action<String> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateBalanceRequest();
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Images

        /// <summary>
        /// Get list of images.
        /// </summary>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void GetImages(Action<List<Image>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetImagesRequest();
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Create server image.
        /// </summary>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        /// <param name="name">User-defined image name.</param>
        /// <param name="techName">Technical image name (only latin symbols and digits).</param>
        /// <param name="serverID">Server ID.</param>
        public void CreateImage(String name, String techName, Int32 serverID, Action<Image> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateImageRequest(name, techName, serverID);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Delete image.
        /// </summary>
        /// <param name="imageID">Image ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void DeleteImage(Int32 imageID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteImageRequest(imageID);
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Private networks

        /// <summary>
        /// Get list of networks.
        /// </summary>
        public void GetNetworks(Action<List<Network>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetNetworksRequest();
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Get network info by ID.
        /// </summary>
        /// <param name="networkID">Network unique ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void GetNetwork(Int32 networkID, Action<Network> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetNetworkRequest(networkID);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Create new network.
        /// </summary>
        /// <param name="name">Network name.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void CreateNetwork(String name, Action<Network> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateNetworkRequest(name);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Delete network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void DeleteNetwork(Int32 networkID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteNetworkRequest(networkID);
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region DC

        /// <summary>
        /// Get list of all available DCs.
        /// </summary>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void GetDCs(Action<List<DC>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetDCsRequest();
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Servers

        /// <summary>
        /// Get list of servers.
        /// </summary>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void GetServers(Action<List<Server>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetServersRequest();
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Get server info by ID.
        /// </summary>
        /// <param name="serverID">Server unique ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void GetServer(Int32 serverID, Action<Server> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetServerRequest(serverID);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Create new server.
        /// </summary>
        /// <param name="name">Server name.</param>
        /// <param name="cpu">Number of CPU.</param>
        /// <param name="ram">Volume of RAM (Mb).</param>
        /// <param name="hdd">Hard disk space (Gb).</param>
        /// <param name="imageID">Initial image ID.</param>
        /// <param name="hddType">HDD type of server.</param>
        /// <param name="isHighPerformance">True if server is located in highperformance pool.</param>
        /// <param name="dcLocation">Data center technical title.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void CreateServer(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID, String hddType, Boolean isHighPerformance, String dcLocation, Action<Server> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateServerRequest(name, cpu, ram, hdd, imageID, hddType, isHighPerformance, dcLocation);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Change server configuration.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="cpu">Number of CPU.</param>
        /// <param name="ram">Volume of RAM (Mb).</param>
        /// <param name="hdd">Hard disk space (Gb).</param>
        /// <param name="hddType">HDD type of server.</param>
        /// <param name="isHighPerformance">True if server is located in highperformance pool.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void ChangeServer(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd, String hddType, Boolean isHighPerformance, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateChangeServerRequest(serverID, cpu, ram, hdd, hddType, isHighPerformance);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Delete server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void DeleteServer(Int32 serverID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteServerRequest(serverID);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Action for power server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="type">Type of action.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void PowerServer(Int32 serverID, Power type, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreatePowerServerRequest(serverID, type.ToString());
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Action for connecting/disconnecting server network.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="type">Type of action.</param>
        /// <param name="networkID">Private network ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void ServerNetwork(Int32 serverID, NetworkAction type, Int32? networkID, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateServerNetworkRequest(serverID, type.ToString(), networkID);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Get list of active actions for server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void GetActions(Int32 serverID, Action<List<Action>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetActionsRequest(serverID);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Get information about action by ID.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="actionID">Action ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void GetAction(Int32 serverID, Int32 actionID, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetActionRequest(serverID, actionID);
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Domains

        /// <summary>
        /// Get list of domains.
        /// </summary>
        /// <returns>List of servers.</returns>
        public void GetDomains(Action<List<Domain>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetDomainsRequest();
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Get server info by ID.
        /// </summary>
        /// <param name="domainID">Domain unique ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void GetDomain(Int32 domainID, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetDomainRequest(domainID);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Create new domain.
        /// </summary>
        /// <param name="name">Domain name.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void CreateDomain(String name, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateDomainRequest(name);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Delete domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void DeleteDomain(Int32 domainID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteDomainRequest(domainID);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXX.XXX.XXX.XXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void CreateARecord(Int32 domainID, String ip, String name, String ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateARecordRequest(domainID, ip, name,ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void CreateAAAARecord(Int32 domainID, String ip, String name, String ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateAAAARecordRequest(domainID, ip, name, ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Canonical name or @ symbol.</param>
        /// <param name="mnemonicName">Mnemonic name.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void CreateCNAMERecord(Int32 domainID, String name, String mnemonicName, String ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateCNAMERecordRequest(domainID, name, mnemonicName, ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostname">Domain name or @ symbol.</param>
        /// <param name="priority">Record priority.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void CreateMXRecord(Int32 domainID, String hostname, String priority, String ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateMXRecordRequest(domainID, hostname, priority, ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostname">Domain name or @ symbol.</param>
        /// <param name="name">Domain name of NS-server.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void CreateNSRecord(Int32 domainID, String hostname, String name, String ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateNSRecordRequest(domainID, hostname, name, ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="text">Text.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void CreateTXTRecord(Int32 domainID, String name, String text, String ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateTXTRecordRequest(domainID, name, text, ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Delete record for domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="recordID">Record ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void DeleteRecord(Int32 domainID, Int32 recordID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteRecordRequest(domainID, recordID);
            ExecuteAsync(request, success, failure);
        }

        /// <summary>
        /// Create SRV-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="service">Service name.</param>
        /// <param name="proto">Used protocol.</param>
        /// <param name="name">Domain name.</param>
        /// <param name="priority">Target host priority.</param>
        /// <param name="weight">Record weight.</param>
        /// <param name="port">Used port.</param>
        /// <param name="target">Canonical computer name of service.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        public void CreateSRVRecord(Int32 domainID, String service, String proto, String name, String priority, String weight, String port, String target, String ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateSRVRecordRequest(domainID, service, proto, name, priority, weight, port, target, ttl);
            ExecuteAsync(request, success, failure);
        }

        #endregion
    }
}
