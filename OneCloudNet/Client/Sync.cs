namespace OneCloudNet.Client
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using OneCloudNet.Enums;
    using OneCloudNet.Models;
    using Action = OneCloudNet.Models.Action;

    public partial class OneCloudNetClient
    {
        #region Customer

        /// <summary>
        /// Get account balance.
        /// </summary>
        /// <returns>Current balance.</returns>
        public string Balance()
        {
            var request = _requestHelper.CreateBalanceRequest();
            return Execute(request).Content.Replace("\"", string.Empty);
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

        public Image CreateImage(string name, string techName, int serverID)
        {
            var request = _requestHelper.CreateCreateImageRequest(name, techName, serverID);
            return Execute<Image>(request);
        }

        public bool DeleteImage(int imageID)
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

        public Network GetNetwork(int networkID)
        {
            var request = _requestHelper.CreateGetNetworkRequest(networkID);
            return Execute<Network>(request);
        }

        public Network CreateNetwork(string name)
        {
            var request = _requestHelper.CreateCreateNetworkRequest(name);
            return Execute<Network>(request);
        }

        public bool DeleteNetwork(int networkID)
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

        public Server GetServer(int serverID)
        {
            var request = _requestHelper.CreateGetServerRequest(serverID);

            return Execute<Server>(request);
        }

        public Server CreateServer(string name, int cpu, int ram, int hdd, string imageID, string hddType, bool isHighPerformance, string dcLocation)
        {
            var request = _requestHelper.CreateCreateServerRequest(name, cpu, ram, hdd, imageID, hddType, isHighPerformance, dcLocation);

            return Execute<Server>(request);
        }

        public Action ChangeServer(int serverID, int cpu, int ram, int hdd, string hddType, bool isHighPerformance)
        {
            var request = _requestHelper.CreateChangeServerRequest(serverID, cpu, ram, hdd, hddType, isHighPerformance);

            return Execute<Action>(request);
        }

        public bool DeleteServer(int serverID)
        {
            var request = _requestHelper.CreateDeleteServerRequest(serverID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public Action PowerServer(int serverID, Power type)
        {
            var request = _requestHelper.CreatePowerServerRequest(serverID, type.ToString());

            return Execute<Action>(request);
        }

        public Action ServerNetwork(int serverID, NetworkAction type, int? networkID)
        {
            var request = _requestHelper.CreateServerNetworkRequest(serverID, type.ToString(), networkID);

            return Execute<Action>(request);
        }

        public IEnumerable<Action> GetActions(int serverID)
        {
            var request = _requestHelper.CreateGetActionsRequest(serverID);

            return Execute<List<Action>>(request);
        }

        public Action GetAction(int serverID, int actionID)
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
        public Domain GetDomain(int domainID)
        {
            var request = _requestHelper.CreateGetDomainRequest(domainID);

            return Execute<Domain>(request);
        }

        /// <summary>
        /// Create new domain.
        /// </summary>
        /// <param name="name">Domain name.</param>
        /// <returns>Created domain information.</returns>
        public Domain CreateDomain(string name)
        {
            var request = _requestHelper.CreateCreateDomainRequest(name);

            return Execute<Domain>(request);
        }

        /// <summary>
        /// Delete domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <returns>Result of operation.</returns>
        public bool DeleteDomain(int domainID)
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
        public Domain CreateARecord(int domainID, string ip, string name, string ttl)
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
        public Domain CreateAAAARecord(int domainID, string ip, string name, string ttl)
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
        public Domain CreateCNAMERecord(int domainID, string name, string mnemonicName, string ttl)
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
        public Domain CreateMXRecord(int domainID, string hostname, string priority, string ttl)
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
        public Domain CreateNSRecord(int domainID, string hostname, string name, string ttl)
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
        public Domain CreateTXTRecord(int domainID, string name, string text, string ttl)
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
        public bool DeleteRecord(int domainID, int recordID)
        {
            var request = _requestHelper.CreateDeleteRecordRequest(domainID, recordID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public Domain CreateSRVRecord(int domainID, string service, string proto, string name, string priority, string weight, string port, string target, string ttl)
        {
            var request = _requestHelper.CreateCreateSRVRecordRequest(domainID, service, proto, name, priority, weight, port, target, ttl);
            return Execute<Domain>(request);
        }

        #endregion
    }
}
