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

    /// <summary>
    /// The main 1Cloud API client interface.
    /// </summary>
    public interface IOneCloudNetClient
    {
        #region Properties

        /// <summary>
        /// Gets or sets proxy settings.
        /// </summary>
        IWebProxy Proxy { get; set; }

        #endregion

        #region Asynchronious requests

        #region Customer

        /// <summary>
        /// Get account balance.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void Balance(Action<string> success, Action<OneCloudException> failure);

        #endregion

        #region Account

        /// <summary>
        /// Get account info.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetAccount(Action<Account> success, Action<OneCloudException> failure);

        #endregion

        #region Storages

        /// <summary>
        /// Get storage information.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetStorage(Action<Storage> success, Action<OneCloudException> failure);

        /// <summary>
        /// Activate storage.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void ActivateStorage(Action<Storage> success, Action<OneCloudException> failure);

        /// <summary>
        /// Deactivate storage.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeactivateStorage(Action<Storage> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get the list of storage users.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetStorageUsers(Action<List<StorageUser>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create new storage user.
        /// </summary>
        /// <param name="userName">Username.</param>
        /// <param name="persistPassword">Flag whether to keep password.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateStorageUser(int userName, bool persistPassword, Action<StorageUser> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get storage user information.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetStorageUser(int userID, Action<StorageUser> success, Action<OneCloudException> failure);

        /// <summary>
        /// Change storage user password.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <param name="persistPassword">Flag whether to keep password.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void ChangeStorageUserPassword(int userID, bool persistPassword, Action<StorageUser> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete existing storage user.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteStorageUser(int userID, Action<StorageUser> success, Action<OneCloudException> failure);

        /// <summary>
        /// Block storage user.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void BlockStorageUser(int userID, Action<StorageUser> success, Action<OneCloudException> failure);

        /// <summary>
        /// Unblock storage user.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void UnblockStorageUser(int userID, Action<StorageUser> success, Action<OneCloudException> failure);

        #endregion

        #region Images

        /// <summary>
        /// Get list of images.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetImages(Action<List<Image>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create server image.
        /// </summary>
        /// <param name="name">User-defined image name.</param>
        /// <param name="techName">Technical image name (only latin symbols and digits).</param>
        /// <param name="serverID">Server ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateImage(string name, string techName, int serverID, Action<Image> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete image.
        /// </summary>
        /// <param name="imageID">Image ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteImage(int imageID, Action<IRestResponse> success, Action<OneCloudException> failure);

        #endregion

        #region Private networks

        /// <summary>
        /// Get list of private networks.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetNetworks(Action<List<PrivateNetwork>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get private network info by ID.
        /// </summary>
        /// <param name="networkID">Network unique ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetNetwork(int networkID, Action<PrivateNetwork> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create new private network.
        /// </summary>
        /// <param name="name">Network name.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateNetwork(string name, Action<PrivateNetwork> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete private network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteNetwork(int networkID, Action<IRestResponse> success, Action<OneCloudException> failure);

        /// <summary>
        /// Edit private network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <param name="name">Network name.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void EditNetwork(int networkID, string name, Action<PrivateNetwork> success, Action<OneCloudException> failure);

        #endregion

        #region Public networks

        /// <summary>
        /// Get list of public networks.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetPublicNetworks(Action<IEnumerable<PublicNetwork>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get public network info by ID.
        /// </summary>
        /// <param name="networkID">Network unique ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetPublicNetwork(int networkID, Action<PublicNetwork> success, Action<OneCloudException> failure);

        /// <summary>
        /// Order new public network.
        /// </summary>
        /// <param name="networkCapacity">Network capacity.</param>
        /// <param name="name">Network name.</param>
        /// <param name="bandWidth">Network bandwidth.</param>
        /// <param name="dcLocation">Data center location.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void OrderPublicNetwork(int networkCapacity, string name, int bandWidth, string dcLocation, Action<PublicNetwork> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete public network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeletePublicNetwork(int networkID, Action<IRestResponse> success, Action<OneCloudException> failure);

        /// <summary>
        /// Edit public network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <param name="bandWidth">Network bandwidth.</param>
        /// <param name="name">Network name.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void EditPublicNetwork(int networkID, int bandWidth, string name, Action<PublicNetwork> success, Action<OneCloudException> failure);

        #endregion

        #region Data centers

        /// <summary>
        /// Get list of all available DCs.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetDCs(Action<List<DC>> success, Action<OneCloudException> failure);

        #endregion

        #region SSHKeys

        /// <summary>
        /// Get list of SSHKeys.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetSSHKeys(Action<List<SSHKey>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get SSHKey info by ID.
        /// </summary>
        /// <param name="keyID">SSHKey unique ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetSSHKey(int keyID, Action<SSHKey> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create new SSHKey.
        /// </summary>
        /// <param name="title">The title of the key.</param>
        /// <param name="publicKey">Key's public key.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateSSHKey(string title, string publicKey, Action<SSHKey> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete SSHKey.
        /// </summary>
        /// <param name="keyID">SSHKey ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteSSHKey(int keyID, Action<IRestResponse> success, Action<OneCloudException> failure);

        #endregion

        #region Servers

        /// <summary>
        /// Get list of servers.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetServers(Action<List<Server>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get server info by ID.
        /// </summary>
        /// <param name="serverID">Server unique ID.</param>
        /// <param name="success">Callback for successful result.</param>
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
        /// <param name="isBackupActive">Flag whether backup is active.</param>
        /// <param name="backupPeriod">Backup depth (7, 14, 21, 28 days).</param>
        /// <param name="sshKeys">List of related SSH keys IDs.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        /// <param name="networkID">Linked network ID.</param>
        /// <param name="networkBandwidth">The network bandwidth.</param>
        /// <param name="isNeedSysprep">The flag whether Windows preliminary work is necessary.</param>
        void CreateServer(string name, int cpu, int ram, int hdd, string imageID, string hddType, bool isHighPerformance, string dcLocation, bool isBackupActive, int backupPeriod, List<int> sshKeys, Action<Server> success, Action<OneCloudException> failure, int? networkID = null, int? networkBandwidth = null, bool? isNeedSysprep = null);

        /// <summary>
        /// Change server configuration.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="cpu">Number of CPU.</param>
        /// <param name="ram">Volume of RAM (Mb).</param>
        /// <param name="hdd">Hard disk space (Gb).</param>
        /// <param name="hddType">HDD type of server.</param>
        /// <param name="isHighPerformance">True if server is located in highperformance pool.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void ChangeServer(int serverID, int cpu, int ram, int hdd, string hddType, bool isHighPerformance, Action<Action> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteServer(int serverID, Action<IRestResponse> success, Action<OneCloudException> failure);

        /// <summary>
        /// Copy existing server to a new instance.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="name">New server instance name.</param>
        /// <param name="networkID">Network ID to connect to.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CopyServer(int serverID, string name, int networkID, Action<Server> success, Action<OneCloudException> failure);

        /// <summary>
        /// Rebuild the existing server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="imageID">Image ID server is based on.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        /// <param name="isNeedSysprep">The flag whether Windows preliminary work is necessary.</param>
        void RebuildServer(int serverID, int imageID, Action<Server> success, Action<OneCloudException> failure, bool? isNeedSysprep = null);

        /// <summary>
        /// Action for power server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="type">Type of action.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void PowerServer(int serverID, Power type, Action<Action> success, Action<OneCloudException> failure);

        /// <summary>
        /// Action for connecting/disconnecting server network.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="type">Type of action.</param>
        /// <param name="networkID">Private network ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void ServerNetwork(int serverID, NetworkAction type, int networkID, Action<Action> success, Action<OneCloudException> failure);

        /// <summary>
        /// Change server's network bandwidth.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="networkLinkID">Server's linked network ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void ServerNetworkBandwidth(int serverID, int networkLinkID, Action<Action> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get list of active actions for server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetActions(int serverID, Action<List<Action>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get information about action by ID.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="actionID">Action ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetAction(int serverID, int actionID, Action<Action> success, Action<OneCloudException> failure);

        #endregion

        #region Domains

        /// <summary>
        /// Get list of domains.
        /// </summary>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetDomains(Action<List<Domain>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get server info by ID.
        /// </summary>
        /// <param name="domainID">Domain unique ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetDomain(int domainID, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create new domain.
        /// </summary>
        /// <param name="name">Domain name.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateDomain(string name, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteDomain(int domainID, Action<IRestResponse> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXX.XXX.XXX.XXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateARecord(int domainID, string ip, string name, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateAAAARecord(int domainID, string ip, string name, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Canonical name or @ symbol.</param>
        /// <param name="mnemonicName">Mnemonic name.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateCNAMERecord(int domainID, string name, string mnemonicName, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostname">Domain name.</param>
        /// <param name="priority">Record priority.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateMXRecord(int domainID, string hostname, string priority, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostName">Domain name or @ symbol.</param>
        /// <param name="name">Domain name of NS-server.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateNSRecord(int domainID, string hostName, string name, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostName">Domain name or @ symbol.</param>
        /// <param name="text">Text.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <param name="success">Callback for successful result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateTXTRecord(int domainID, string hostName, string text, string ttl, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete record for domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="recordID">Record ID.</param>
        /// <param name="success">Callback for successful result.</param>
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
        /// <param name="success">Callback for successful result.</param>
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

        #region Account

        /// <summary>
        /// Get account info.
        /// </summary>
        /// <returns>Account info.</returns>
        Account GetAccount();

        #endregion

        #region Storages

        /// <summary>
        /// Get storage information.
        /// </summary>
        /// <returns>Storage info.</returns>
        Storage GetStorage();

        /// <summary>
        /// Activate storage.
        /// </summary>
        /// <returns>Storage info.</returns>
        Storage ActivateStorage();

        /// <summary>
        /// Deactivate storage.
        /// </summary>
        /// <returns>Storage info.</returns>
        Storage DeactivateStorage();

        /// <summary>
        /// Get the list of storage users.
        /// </summary>
        /// <returns>List of storage users.</returns>
        List<StorageUser> GetStorageUsers();

        /// <summary>
        /// Create new storage user.
        /// </summary>
        /// <param name="userName">Username.</param>
        /// <param name="persistPassword">Flag whether to keep password.</param>
        /// <returns>Storage user info.</returns>
        StorageUser CreateStorageUser(int userName, bool persistPassword);

        /// <summary>
        /// Get storage user information.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <returns>Storage user info.</returns>
        StorageUser GetStorageUser(int userID);

        /// <summary>
        /// Change storage user password.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <param name="persistPassword">Flag whether to keep password.</param>
        /// <returns>Storage user info.</returns>
        StorageUser ChangeStorageUserPassword(int userID, bool persistPassword);

        /// <summary>
        /// Delete existing storage user.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <returns>Storage user info.</returns>
        StorageUser DeleteStorageUser(int userID);

        /// <summary>
        /// Block storage user.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <returns>Storage user info.</returns>
        StorageUser BlockStorageUser(int userID);

        /// <summary>
        /// Unblock storage user.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <returns>Storage user info.</returns>
        StorageUser UnblockStorageUser(int userID);

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
        /// Get list of private networks.
        /// </summary>
        /// <returns>List of networks.</returns>
        IEnumerable<PrivateNetwork> GetNetworks();

        /// <summary>
        /// Get private network info by ID.
        /// </summary>
        /// <param name="networkID">Network unique ID.</param>
        /// <returns>Network information.</returns>
        PrivateNetwork GetNetwork(int networkID);

        /// <summary>
        /// Create new private network.
        /// </summary>
        /// <param name="name">Network name.</param>
        /// <returns>Created network information.</returns>
        PrivateNetwork CreateNetwork(string name);

        /// <summary>
        /// Delete private network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <returns>Result of operation.</returns>
        bool DeleteNetwork(int networkID);

        /// <summary>
        /// Edit private network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <param name="name">Network name.</param>
        /// <returns>Network information.</returns>
        PrivateNetwork EditNetwork(int networkID, string name);

        #endregion

        #region Public networks

        /// <summary>
        /// Get list of public networks.
        /// </summary>
        /// <returns>List of networks.</returns>
        IEnumerable<PublicNetwork> GetPublicNetworks();

        /// <summary>
        /// Get public network info by ID.
        /// </summary>
        /// <param name="networkID">Network unique ID.</param>
        /// <returns>Network information.</returns>
        PublicNetwork GetPublicNetwork(int networkID);

        /// <summary>
        /// Order new public network.
        /// </summary>
        /// <param name="networkCapacity">Network capacity.</param>
        /// <param name="name">Network name.</param>
        /// <param name="bandWidth">Network bandwidth.</param>
        /// <param name="dcLocation">Data center location.</param>
        /// <returns>Created network information.</returns>
        PublicNetwork OrderPublicNetwork(int networkCapacity, string name, int bandWidth, string dcLocation);

        /// <summary>
        /// Delete public network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <returns>Result of operation.</returns>
        bool DeletePublicNetwork(int networkID);

        /// <summary>
        /// Edit public network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <param name="bandWidth">Network bandwidth.</param>
        /// <param name="name">Network name.</param>
        /// <returns>Network information.</returns>
        PublicNetwork EditPublicNetwork(int networkID, int bandWidth, string name);

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
        /// <param name="title">Key's title.</param>
        /// <param name="publicKey">Key's public key.</param>
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
        /// <param name="isBackupActive">Flag whether backup is active.</param>
        /// <param name="backupPeriod">Backup depth (7, 14, 21, 28 days).</param>
        /// <param name="sshKeys">List of related SSH keys IDs.</param>
        /// <param name="networkID">Linked network ID.</param>
        /// <param name="networkBandwidth">The network bandwidth.</param>
        /// <param name="isNeedSysprep">The flag whether Windows preliminary work is necessary.</param>
        /// <returns>Created server information.</returns>
        Server CreateServer(string name, int cpu, int ram, int hdd, string imageID, string hddType, bool isHighPerformance, string dcLocation, bool isBackupActive, int backupPeriod, List<int> sshKeys, int? networkID = null, int? networkBandwidth = null, bool? isNeedSysprep = null);

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
        /// Copy existing server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="name">New instance server name.</param>
        /// <param name="networkID">Network ID server to link to.</param>
        /// <returns>New server instance.</returns>
        Server CopyServer(int serverID, string name, int networkID);

        /// <summary>
        /// Rebuild the existing server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="imageID">Image ID server is based on.</param>
        /// <param name="isNeedSysprep">The flag whether Windows preliminary work is necessary.</param>
        /// <returns>Rebuilt server instance.</returns>
        Server RebuildServer(int serverID, int imageID, bool? isNeedSysprep = null);

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
        /// <returns>Action, caused by operation.</returns>
        Action ServerNetwork(int serverID, NetworkAction type, int networkID);

        /// <summary>
        /// Change network bandwidth.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="networkLinkID">Linked network ID.</param>
        /// <returns>Action, caused by operation.</returns>
        Action ServerNetworkBandwidth(int serverID, int networkLinkID);

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
        /// <returns>Created domain record.</returns>
        Domain CreateARecord(int domainID, string ip, string name, string ttl);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns>Created domain record.</returns>
        Domain CreateAAAARecord(int domainID, string ip, string name, string ttl);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Canonical name or @ symbol.</param>
        /// <param name="mnemonicName">Mnemonic name.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns>Created domain record.</returns>
        Domain CreateCNAMERecord(int domainID, string name, string mnemonicName, string ttl);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostname">Domain name.</param>
        /// <param name="priority">Record priority.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns>Created domain record.</returns>
        Domain CreateMXRecord(int domainID, string hostname, string priority, string ttl);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostName">Domain name or @ symbol.</param>
        /// <param name="name">Domain name of NS-server.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns>Created domain record.</returns>
        Domain CreateNSRecord(int domainID, string hostName, string name, string ttl);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostName">Domain name or @ symbol.</param>
        /// <param name="text">Text.</param>
        /// <param name="ttl">Time to live (in seconds).</param>
        /// <returns>Created domain record.</returns>
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
        /// <returns>Created domain record.</returns>
        Domain CreateSRVRecord(int domainID, string service, string proto, string name, string priority, string weight, string port, string target, string ttl);

        #endregion

        #endregion
    }
}