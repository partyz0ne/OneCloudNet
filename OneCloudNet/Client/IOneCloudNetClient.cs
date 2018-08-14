namespace OneCloudNet.Client
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using OneCloudNet.Enums;
    using OneCloudNet.Exceptions;
    using OneCloudNet.Models;
    using RestSharp;
    using Action = OneCloudNet.Models.Action;

    public interface IOneCloudNetClient
    {
        #region Properties

        /// <summary>
        /// Proxy settings.
        /// </summary>
        IWebProxy Proxy { get; set; }

        #endregion

        #region Asynchronious requests

        #region Customer

        /// <summary>
        /// Get account balance.
        /// </summary>
        /// <returns>Current balance.</returns>
        void Balance(Action<string> success, Action<OneCloudException> failure);

        #endregion

        #region Images

        /// <summary>
        /// Get list of images.
        /// </summary>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetImages(Action<List<Image>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create server image.
        /// </summary>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        /// <param name="name">User-defined image name.</param>
        /// <param name="techName">Technical image name (only latin symbols and digits).</param>
        /// <param name="serverID">Server ID.</param>
        void CreateImage(string name, string techName, int serverID, Action<Image> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete image.
        /// </summary>
        /// <param name="imageID">Image ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteImage(int imageID, Action<IRestResponse> success, Action<OneCloudException> failure);

        #endregion

        #region Private networks

        /// <summary>
        /// Get list of networks.
        /// </summary>
        void GetNetworks(Action<List<Network>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get network info by ID.
        /// </summary>
        /// <param name="networkID">Network unique ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetNetwork(int networkID, Action<Network> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create new network.
        /// </summary>
        /// <param name="name">Network name.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateNetwork(string name, Action<Network> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteNetwork(int networkID, Action<IRestResponse> success, Action<OneCloudException> failure);

        #endregion

        #region Data centers

        /// <summary>
        /// Get list of all available DCs.
        /// </summary>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetDCs(Action<List<DC>> success, Action<OneCloudException> failure);

        #endregion
		
		#region SSHKeys

        /// <summary>
        /// Get list of SSHKeys.
        /// </summary>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetSSHKeys(Action<List<SSHKey>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get SSHKey info by ID.
        /// </summary>
        /// <param name="keyID">SSHKey unique ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetSSHKey(int keyID, Action<SSHKey> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create new SSHKey.
        /// </summary>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateSSHKey(string title, string publicKey, Action<SSHKey> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete SSHKey.
        /// </summary>
        /// <param name="keyID">SSHKey ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteSSHKey(int keyID, Action<IRestResponse> success, Action<OneCloudException> failure);

        #endregion

        #region Servers

        /// <summary>
        /// Get list of servers.
        /// </summary>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetServers(Action<List<Server>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get server info by ID.
        /// </summary>
        /// <param name="serverID">Server unique ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetServer(int serverID, Action<Server> success, Action<OneCloudException> failure);

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
        void CreateServer(string name, int cpu, int ram, int hdd, string imageID, string hddType, bool isHighPerformance, string dcLocation, Action<Server> success, Action<OneCloudException> failure);

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
        void ChangeServer(int serverID, int cpu, int ram, int hdd, string hddType, bool isHighPerformance, Action<Action> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteServer(int serverID, Action<IRestResponse> success, Action<OneCloudException> failure);

        /// <summary>
        /// Action for power server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="type">Type of action.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void PowerServer(int serverID, Power type, Action<Action> success, Action<OneCloudException> failure);

        /// <summary>
        /// Action for connecting/disconnecting server network.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="type">Type of action.</param>
        /// <param name="networkID">Private network ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void ServerNetwork(int serverID, NetworkAction type, int? networkID, Action<Action> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get list of active actions for server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetActions(int serverID, Action<List<Action>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get information about action by ID.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="actionID">Action ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetAction(int serverID, int actionID, Action<Action> success, Action<OneCloudException> failure);

        #endregion

        #region Domains

        /// <summary>
        /// Get list of domains.
        /// </summary>
        /// <returns>List of servers.</returns>
        void GetDomains(Action<List<Domain>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get server info by ID.
        /// </summary>
        /// <param name="domainID">Domain unique ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetDomain(int domainID, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create new domain.
        /// </summary>
        /// <param name="name">Domain name.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateDomain(string name, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteDomain(int domainID, Action<IRestResponse> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXX.XXX.XXX.XXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateARecord(int domainID, string ip, string name, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateAAAARecord(int domainID, string ip, string name, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Canonical name or @ symbol.</param>
        /// <param name="mnemonicName">Mnemonic name.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateCNAMERecord(int domainID, string name, string mnemonicName, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostname">Domain name.</param>
        /// <param name="priority">Record priority.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateMXRecord(int domainID, string hostname, string priority, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostName">Domain name or @ symbol.</param>
        /// <param name="name">Domain name of NS-server.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateNSRecord(int domainID, string hostName, string name, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostName">Domain name or @ symbol.</param>
        /// <param name="text">Text.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateTXTRecord(int domainID, string hostName, string text, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete record for domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="recordID">Record ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteRecord(int domainID, int recordID, Action<IRestResponse> success, Action<OneCloudException> failure);

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
        void CreateSRVRecord(int domainID, string service, string proto, string name, string priority, string weight, string port, string target, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        #endregion

        #endregion

        #region Synchronious requests

        #region Customer

        /// <summary>
        /// Get account balance.
        /// </summary>
        /// <returns>Current balance.</returns>
        string Balance();

        #endregion

        #region Images

        /// <summary>
        /// Get list of images.
        /// </summary>
        /// <returns>List of images.</returns>
        IEnumerable<Image> GetImages();

        /// <summary>
        /// Create server image.
        /// </summary>
        /// <param name="name">User-defined image name.</param>
        /// <param name="techName">Technical image name (only latin symbols and digits).</param>
        /// <param name="serverID">Server ID.</param>
        /// <returns>Created image.</returns>
        Image CreateImage(string name, string techName, int serverID);

        /// <summary>
        /// Delete image.
        /// </summary>
        /// <param name="imageID">Image ID.</param>
        /// <returns>Result of operation.</returns>
        bool DeleteImage(int imageID);

        #endregion

        #region Private networks

        /// <summary>
        /// Get list of networks.
        /// </summary>
        /// <returns>List of networks.</returns>
        IEnumerable<Network> GetNetworks();

        /// <summary>
        /// Get network info by ID.
        /// </summary>
        /// <param name="networkID">Network unique ID.</param>
        /// <returns>Network information.</returns>
        Network GetNetwork(int networkID);

        /// <summary>
        /// Create new network.
        /// </summary>
        /// <param name="name">Network name.</param>
        /// <returns>Created network information.</returns>
        Network CreateNetwork(string name);

        /// <summary>
        /// Delete network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <returns>Result of operation.</returns>
        bool DeleteNetwork(int networkID);

        #endregion

        #region Data centers

        /// <summary>
        /// Get list of all available DCs.
        /// </summary>
        /// <returns>List of DCs.</returns>
        IEnumerable<DC> GetDCs();

        #endregion

        #region SSHKeys

        /// <summary>
        /// Get list of keys.
        /// </summary>
        /// <returns>List of keys.</returns>
        IEnumerable<SSHKey> GetSSHKeys();

        /// <summary>
        /// Get key info by ID.
        /// </summary>
        /// <param name="keyID">SSHKey unique ID.</param>
        /// <returns>SSHKey information.</returns>
        SSHKey GetSSHKey(int keyID);

        /// <summary>
        /// Create new key.
        /// </summary>
        /// <returns>Created key information.</returns>
        SSHKey CreateSSHKey(string title, string publicKey);

        /// <summary>
        /// Delete key.
        /// </summary>
        /// <param name="keyID">SSHKey ID.</param>
        /// <returns>Result of operation.</returns>
        bool DeleteSSHKey(int keyID);

        #endregion

        #region Servers

        /// <summary>
        /// Get list of servers.
        /// </summary>
        /// <returns>List of servers.</returns>
        IEnumerable<Server> GetServers();

        /// <summary>
        /// Get server info by ID.
        /// </summary>
        /// <param name="serverID">Server unique ID.</param>
        /// <returns>Server information.</returns>
        Server GetServer(int serverID);

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
        /// <returns>Created server information.</returns>
        Server CreateServer(string name, int cpu, int ram, int hdd, string imageID, string hddType, bool isHighPerformance, string dcLocation);

        /// <summary>
        /// Change server configuration.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="cpu">Number of CPU.</param>
        /// <param name="ram">Volume of RAM (Mb).</param>
        /// <param name="hdd">Hard disk space (Gb).</param>
        /// <param name="hddType">HDD type of server.</param>
        /// <param name="isHighPerformance">True if server is located in highperformance pool.</param>
        /// <returns>Action, caused by changing operation.</returns>
        Action ChangeServer(int serverID, int cpu, int ram, int hdd, string hddType, bool isHighPerformance);

        /// <summary>
        /// Delete server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <returns>Result of operation.</returns>
        bool DeleteServer(int serverID);

        /// <summary>
        /// Action for power server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="type">Type of action.</param>
        /// <returns>Action, caused by operation.</returns>
        Action PowerServer(int serverID, Power type);
        
        /// <summary>
        /// Action for connecting/disconnecting server network.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="type">Type of action.</param>
        /// <param name="networkID">Private network ID.</param>
        Action ServerNetwork(int serverID, NetworkAction type, int? networkID);

        /// <summary>
        /// Get list of active actions for server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <returns>List of operations.</returns>
        IEnumerable<Action> GetActions(int serverID);

        /// <summary>
        /// Get information about action by ID.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="actionID">Action ID.</param>
        /// <returns>Action information.</returns>
        Action GetAction(int serverID, int actionID);

        #endregion

        #region Domains

        /// <summary>
        /// Get list of domains.
        /// </summary>
        /// <returns>List of servers.</returns>
        IEnumerable<Domain> GetDomains();

        /// <summary>
        /// Get server info by ID.
        /// </summary>
        /// <param name="domainID">Domain unique ID.</param>
        /// <returns>Server information.</returns>
        Domain GetDomain(int domainID);

        /// <summary>
        /// Create new domain.
        /// </summary>
        /// <param name="name">Domain name.</param>
        /// <returns>Created domain information.</returns>
        Domain CreateDomain(string name);

        /// <summary>
        /// Delete domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <returns>Result of operation.</returns>
        bool DeleteDomain(int domainID);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXX.XXX.XXX.XXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        Domain CreateARecord(int domainID, string ip, string name, string ttl);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        Domain CreateAAAARecord(int domainID, string ip, string name, string ttl);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Canonical name or @ symbol.</param>
        /// <param name="mnemonicName">Mnemonic name.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        Domain CreateCNAMERecord(int domainID, string name, string mnemonicName, string ttl);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostname">Domain name.</param>
        /// <param name="priority">Record priority.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        Domain CreateMXRecord(int domainID, string hostname, string priority, string ttl);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostName">Domain name or @ symbol.</param>
        /// <param name="name">Domain name of NS-server.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        Domain CreateNSRecord(int domainID, string hostName, string name, string ttl);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostName">Domain name or @ symbol.</param>
        /// <param name="text">Text.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns></returns>
        Domain CreateTXTRecord(int domainID,  string hostName, string text, string ttl);

        /// <summary>
        /// Delete record for domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="recordID">Record ID.</param>
        /// <returns>Result of operation.</returns>
        bool DeleteRecord(int domainID, int recordID);

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
        /// <returns></returns>
        Domain CreateSRVRecord(int domainID, string service, string proto, string name, string priority, string weight, string port, string target, string ttl);

        #endregion

        #endregion
    }
}