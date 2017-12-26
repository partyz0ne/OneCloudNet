using System;
using System.Collections.Generic;
using System.Net;
using OneCloudNet.Enums;
using OneCloudNet.Models;
using Action = OneCloudNet.Models.Action;

namespace OneCloudNet.Client
{
    public partial class OneCloudNetClient
    {
        #region Customer

        /// <summary>
        /// Get account balance.
        /// </summary>
        /// <returns>Current balance.</returns>
        public String Balance()
        {
            var request = _requestHelper.CreateBalanceRequest();
            return Execute(request).Content.Replace("\"", "");
        }

        #endregion

        #region Account

        /// <summary>
        /// Get account info.
        /// </summary>
        /// <returns></returns>
        public Account GetAccount()
        {
            var request = _requestHelper.CreateGetAccountRequest();

            return Execute<Account>(request);
        }

        #endregion

        #region Storages

        public Storage GetStorage()
        {
            var request = _requestHelper.CreateGetStorageRequest();

            return Execute<Storage>(request);
        }

        public Storage ActivateStorage()
        {
            var request = _requestHelper.CreateActivateStorageRequest();

            return Execute<Storage>(request);
        }

        public Storage DeactivateStorage()
        {
            var request = _requestHelper.CreateDeactivateStorageRequest();

            return Execute<Storage>(request);
        }

        #endregion

        #region Images

        public IEnumerable<Image> GetImages()
        {
            var request = _requestHelper.CreateGetImagesRequest();
            return Execute<List<Image>>(request);
        }

        public Image CreateImage(String name, String techName, Int32 serverID)
        {
            var request = _requestHelper.CreateCreateImageRequest(name, techName, serverID);
            return Execute<Image>(request);
        }

        public Boolean DeleteImage(Int32 imageID)
        {
            var request = _requestHelper.CreateDeleteImageRequest(imageID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        #endregion

        #region Private networks

        public IEnumerable<Network> GetNetworks()
        {
            var request = _requestHelper.CreateGetNetworksRequest();
            return Execute<List<Network>>(request);
        }

        public Network GetNetwork(Int32 networkID)
        {
            var request = _requestHelper.CreateGetNetworkRequest(networkID);
            return Execute<Network>(request);
        }

        public Network CreateNetwork(String name)
        {
            var request = _requestHelper.CreateCreateNetworkRequest(name);
            return Execute<Network>(request);
        }

        public Boolean DeleteNetwork(Int32 networkID)
        {
            var request = _requestHelper.CreateDeleteNetworkRequest(networkID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        #endregion

        #region DC

        public IEnumerable<DC> GetDCs()
        {
            var request = _requestHelper.CreateGetDCsRequest();

            return Execute<List<DC>>(request);
        }

        #endregion

        #region Servers

        public IEnumerable<Server> GetServers()
        {
            var request = _requestHelper.CreateGetServersRequest();

            return Execute<List<Server>>(request);
        }

        public Server GetServer(Int32 serverID)
        {
            var request = _requestHelper.CreateGetServerRequest(serverID);

            return Execute<Server>(request);
        }

        public Server CreateServer(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID, String hddType, Boolean isHighPerformance, String dcLocation)
        {
            var request = _requestHelper.CreateCreateServerRequest(name, cpu, ram, hdd, imageID, hddType, isHighPerformance, dcLocation);

            return Execute<Server>(request);
        }

        public Action ChangeServer(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd, String hddType, Boolean isHighPerformance)
        {
            var request = _requestHelper.CreateChangeServerRequest(serverID, cpu, ram, hdd, hddType, isHighPerformance);

            return Execute<Action>(request);
        }

        public Boolean DeleteServer(Int32 serverID)
        {
            var request = _requestHelper.CreateDeleteServerRequest(serverID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public Action PowerServer(Int32 serverID, Power type)
        {
            var request = _requestHelper.CreatePowerServerRequest(serverID, type.ToString());

            return Execute<Action>(request);
        }

        public Action ServerNetwork(Int32 serverID, NetworkAction type, Int32? networkID)
        {
            var request = _requestHelper.CreateServerNetworkRequest(serverID, type.ToString(), networkID);

            return Execute<Action>(request);
        }

        public IEnumerable<Action> GetActions(Int32 serverID)
        {
            var request = _requestHelper.CreateGetActionsRequest(serverID);

            return Execute<List<Action>>(request);
        }

        public Action GetAction(Int32 serverID, Int32 actionID)
        {
            var request = _requestHelper.CreateGetActionRequest(serverID, actionID);

            return Execute<Action>(request);
        }

        #endregion

        #region Domains

        /// <summary>
        /// Get list of domains.
        /// </summary>
        /// <returns>List of servers.</returns>
        public IEnumerable<Domain> GetDomains()
        {
            var request = _requestHelper.CreateGetDomainsRequest();

            return Execute<List<Domain>>(request);
        }

        /// <summary>
        /// Get server info by ID.
        /// </summary>
        /// <param name="domainID">Domain unique ID.</param>
        /// <returns>Server information.</returns>
        public Domain GetDomain(Int32 domainID)
        {
            var request = _requestHelper.CreateGetDomainRequest(domainID);

            return Execute<Domain>(request);
        }

        /// <summary>
        /// Create new domain.
        /// </summary>
        /// <param name="name">Domain name.</param>
        /// <returns>Created domain information.</returns>
        public Domain CreateDomain(String name)
        {
            var request = _requestHelper.CreateCreateDomainRequest(name);

            return Execute<Domain>(request);
        }

        /// <summary>
        /// Delete domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <returns>Result of operation.</returns>
        public Boolean DeleteDomain(Int32 domainID)
        {
            var request = _requestHelper.CreateDeleteDomainRequest(domainID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXX.XXX.XXX.XXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        public Domain CreateARecord(Int32 domainID, String ip, String name, String ttl)
        {
            var request = _requestHelper.CreateCreateARecordRequest(domainID, ip, name, ttl);
            return Execute<Domain>(request);
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        public Domain CreateAAAARecord(Int32 domainID, String ip, String name, String ttl)
        {
            var request = _requestHelper.CreateCreateAAAARecordRequest(domainID, ip, name, ttl);
            return Execute<Domain>(request);
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Canonical name or @ symbol.</param>
        /// <param name="mnemonicName">Mnemonic name.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        public Domain CreateCNAMERecord(Int32 domainID, String name, String mnemonicName, String ttl)
        {
            var request = _requestHelper.CreateCreateCNAMERecordRequest(domainID, name, mnemonicName, ttl);
            return Execute<Domain>(request);
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostname">Domain name or @ symbol.</param>
        /// <param name="priority">Record priority.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        public Domain CreateMXRecord(Int32 domainID, String hostname, String priority, String ttl)
        {
            var request = _requestHelper.CreateCreateMXRecordRequest(domainID, hostname, priority, ttl);
            return Execute<Domain>(request);
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostname">Domain name or @ symbol</param>
        /// <param name="name">Domain name of NS-server.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        public Domain CreateNSRecord(Int32 domainID, String hostname, String name, String ttl)
        {
            var request = _requestHelper.CreateCreateNSRecordRequest(domainID, hostname, name, ttl);
            return Execute<Domain>(request);
        }

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="text">Text.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        public Domain CreateTXTRecord(Int32 domainID, String name, String text, String ttl)
        {
            var request = _requestHelper.CreateCreateTXTRecordRequest(domainID, name, text, ttl);
            return Execute<Domain>(request);
        }

        /// <summary>
        /// Delete record for domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="recordID">Record ID.</param>
        /// <returns>Result of operation.</returns>
        public Boolean DeleteRecord(Int32 domainID, Int32 recordID)
        {
            var request = _requestHelper.CreateDeleteRecordRequest(domainID, recordID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public Domain CreateSRVRecord(Int32 domainID, String service, String proto, String name, String priority, String weight, String port, String target, String ttl)
        {
            var request = _requestHelper.CreateCreateSRVRecordRequest(domainID, service, proto, name, priority, weight, port, target, ttl);
            return Execute<Domain>(request);
        }

        #endregion
    }
}
