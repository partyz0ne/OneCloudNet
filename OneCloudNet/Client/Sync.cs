namespace OneCloudNet.Client
{
    using System.Collections.Generic;
    using System.Net;
    using OneCloudNet.Enums;
    using OneCloudNet.Models;
    using Action = OneCloudNet.Models.Action;

    /// <summary>
    /// The main 1Cloud API client interface.
    /// Synchronous methods.
    /// </summary>
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
        /// <returns>Account info.</returns>
        public Account GetAccount()
        {
            var request = _requestHelper.CreateGetAccountRequest();

            return Execute<Account>(request);
        }

        #endregion

        #region Storages

        /// <summary>
        /// Get storage information.
        /// </summary>
        /// <returns>Storage info.</returns>
        public Storage GetStorage()
        {
            var request = _requestHelper.CreateGetStorageRequest();

            return Execute<Storage>(request);
        }

        /// <summary>
        /// Activate storage.
        /// </summary>
        /// <returns>Storage info.</returns>
        public Storage ActivateStorage()
        {
            var request = _requestHelper.CreateActivateStorageRequest();

            return Execute<Storage>(request);
        }

        /// <summary>
        /// Deactivate storage.
        /// </summary>
        /// <returns>Storage info.</returns>
        public Storage DeactivateStorage()
        {
            var request = _requestHelper.CreateDeactivateStorageRequest();

            return Execute<Storage>(request);
        }

        /// <summary>
        /// Get the list of storage users.
        /// </summary>
        /// <returns>List of storage users.</returns>
        public List<StorageUser> GetStorageUsers()
        {
            var request = _requestHelper.CreateGetStorageUsersRequest();

            return Execute<List<StorageUser>>(request);
        }

        /// <summary>
        /// Create new storage user.
        /// </summary>
        /// <param name="userName">Username.</param>
        /// <param name="persistPassword">Flag whether to keep password.</param>
        /// <returns>Storage user info.</returns>
        public StorageUser CreateStorageUser(int userName, bool persistPassword)
        {
            var request = _requestHelper.CreateCreateStorageUserRequest(userName, persistPassword);

            return Execute<StorageUser>(request);
        }

        /// <summary>
        /// Get storage user information.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <returns>Storage user info.</returns>
        public StorageUser GetStorageUser(int userID)
        {
            var request = _requestHelper.CreateGetStorageUserRequest(userID);

            return Execute<StorageUser>(request);
        }

        /// <summary>
        /// Change storage user password.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <param name="persistPassword">Flag whether to keep password.</param>
        /// <returns>Storage user info.</returns>
        public StorageUser ChangeStorageUserPassword(int userID, bool persistPassword)
        {
            var request = _requestHelper.CreateChangeStorageUserPasswordRequest(userID, persistPassword);

            return Execute<StorageUser>(request);
        }

        /// <summary>
        /// Delete existing storage user.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <returns>Storage user info.</returns>
        public StorageUser DeleteStorageUser(int userID)
        {
            var request = _requestHelper.CreateDeleteStorageUserRequest(userID);

            return Execute<StorageUser>(request);
        }

        /// <summary>
        /// Block storage user.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <returns>Storage user info.</returns>
        public StorageUser BlockStorageUser(int userID)
        {
            var request = _requestHelper.CreateBlockStorageUserRequest(userID);

            return Execute<StorageUser>(request);
        }

        /// <summary>
        /// Unblock storage user.
        /// </summary>
        /// <param name="userID">User ID.</param>
        /// <returns>Storage user info.</returns>
        public StorageUser UnblockStorageUser(int userID)
        {
            var request = _requestHelper.CreateUnblockStorageUserRequest(userID);

            return Execute<StorageUser>(request);
        }

        #endregion

        #region Images

        /// <inheritdoc cref="IOneCloudNetClient" />
        public IEnumerable<Image> GetImages()
        {
            var request = _requestHelper.CreateGetImagesRequest();
            return Execute<List<Image>>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Image CreateImage(string name, string techName, int serverID)
        {
            var request = _requestHelper.CreateCreateImageRequest(name, techName, serverID);
            return Execute<Image>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public bool DeleteImage(int imageID)
        {
            var request = _requestHelper.CreateDeleteImageRequest(imageID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        #endregion

        #region Private networks

        /// <inheritdoc cref="IOneCloudNetClient" />
        public IEnumerable<PrivateNetwork> GetNetworks()
        {
            var request = _requestHelper.CreateGetPrivateNetworksRequest();
            return Execute<List<PrivateNetwork>>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public PrivateNetwork GetNetwork(int networkID)
        {
            var request = _requestHelper.CreateGetPrivateNetworkRequest(networkID);
            return Execute<PrivateNetwork>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public PrivateNetwork CreateNetwork(string name)
        {
            var request = _requestHelper.CreateCreatePrivateNetworkRequest(name);
            return Execute<PrivateNetwork>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public bool DeleteNetwork(int networkID)
        {
            var request = _requestHelper.CreateDeletePrivateNetworkRequest(networkID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public PrivateNetwork EditNetwork(int networkID, string name)
        {
            var request = _requestHelper.CreateEditPrivateNetworkRequest(networkID, name);
            return Execute<PrivateNetwork>(request);
        }

        #endregion

        #region Public networks

        /// <inheritdoc cref="IOneCloudNetClient" />
        public IEnumerable<PublicNetwork> GetPublicNetworks()
        {
            var request = _requestHelper.CreateGetPublicNetworksRequest();
            return Execute<List<PublicNetwork>>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public PublicNetwork GetPublicNetwork(int networkID)
        {
            var request = _requestHelper.CreateGetPublicNetworkRequest(networkID);
            return Execute<PublicNetwork>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public PublicNetwork OrderPublicNetwork(int networkCapacity, string name, int bandWidth, string dcLocation)
        {
            var request = _requestHelper.CreateOrderPublicNetworkRequest(networkCapacity, name, bandWidth, dcLocation);
            return Execute<PublicNetwork>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public bool DeletePublicNetwork(int networkID)
        {
            var request = _requestHelper.CreateDeletePublicNetworkRequest(networkID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public PublicNetwork EditPublicNetwork(int networkID, int bandWidth, string name)
        {
            var request = _requestHelper.CreateEditPublicNetworkRequest(networkID, bandWidth, name);
            return Execute<PublicNetwork>(request);
        }

        #endregion

        #region DC

        /// <inheritdoc cref="IOneCloudNetClient" />
        public IEnumerable<DC> GetDCs()
        {
            var request = _requestHelper.CreateGetDCsRequest();

            return Execute<List<DC>>(request);
        }

        #endregion

        #region SSHKey

        /// <inheritdoc cref="IOneCloudNetClient" />
        public IEnumerable<SSHKey> GetSSHKeys()
        {
            var request = _requestHelper.CreateGetSSHKeysRequest();

            return Execute<List<SSHKey>>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public SSHKey GetSSHKey(int keyID)
        {
            var request = _requestHelper.CreateGetSSHKeyRequest(keyID);

            return Execute<SSHKey>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public SSHKey CreateSSHKey(string title, string publicKey)
        {
            var request = _requestHelper.CreateCreateSSHKeyRequest(title, publicKey);

            return Execute<SSHKey>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public bool DeleteSSHKey(int keyID)
        {
            var request = _requestHelper.CreateDeleteSSHKeyRequest(keyID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        #endregion

        #region Servers

        /// <inheritdoc cref="IOneCloudNetClient" />
        public IEnumerable<Server> GetServers()
        {
            var request = _requestHelper.CreateGetServersRequest();

            return Execute<List<Server>>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Server GetServer(int serverID)
        {
            var request = _requestHelper.CreateGetServerRequest(serverID);

            return Execute<Server>(request);
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
        /// <param name="isBackupActive">Flag whether backup is active.</param>
        /// <param name="backupPeriod">Backup depth (7, 14, 21, 28 days).</param>
        /// <param name="sshKeys">List of related SSH keys IDs.</param>
        /// <param name="networkID">Linked network ID.</param>
        /// <param name="networkBandwidth">The network bandwidth.</param>
        /// <param name="isNeedSysprep">The flag whether Windows preliminary work is necessary.</param>
        /// <returns>Created server information.</returns>
        public Server CreateServer(string name, int cpu, int ram, int hdd, string imageID, string hddType, bool isHighPerformance, string dcLocation, bool isBackupActive, int backupPeriod, List<int> sshKeys, int? networkID = null, int? networkBandwidth = null, bool? isNeedSysprep = null)
        {
            var request = _requestHelper.CreateCreateServerRequest(name, cpu, ram, hdd, imageID, hddType, isHighPerformance, dcLocation, isBackupActive, backupPeriod, sshKeys, networkID, networkBandwidth, isNeedSysprep);

            return Execute<Server>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Action ChangeServer(int serverID, int cpu, int ram, int hdd, string hddType, bool isHighPerformance)
        {
            var request = _requestHelper.CreateChangeServerRequest(serverID, cpu, ram, hdd, hddType, isHighPerformance);

            return Execute<Action>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public bool DeleteServer(int serverID)
        {
            var request = _requestHelper.CreateDeleteServerRequest(serverID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Server CopyServer(int serverID, string name, int networkID)
        {
            var request = _requestHelper.CreateCopyServerRequest(serverID, name, networkID);

            return Execute<Server>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Server RebuildServer(int serverID, int imageID, bool? isNeedSysprep = null)
        {
            var request = _requestHelper.CreateRebuildServerRequest(serverID, imageID, isNeedSysprep);

            return Execute<Server>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Action PowerServer(int serverID, Power type)
        {
            var request = _requestHelper.CreatePowerServerRequest(serverID, type.ToString());

            return Execute<Action>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Action ServerNetwork(int serverID, NetworkAction type, int networkID)
        {
            var request = _requestHelper.CreateServerNetworkRequest(serverID, type.ToString(), networkID);

            return Execute<Action>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Action ServerNetworkBandwidth(int serverID, int networkLinkID)
        {
            var request = _requestHelper.CreateServerNetworkBandwidthRequest(serverID, NetworkAction.EditNetworkBandwidth.ToString(), networkLinkID);

            return Execute<Action>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public IEnumerable<Action> GetActions(int serverID)
        {
            var request = _requestHelper.CreateGetActionsRequest(serverID);

            return Execute<List<Action>>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Action GetAction(int serverID, int actionID)
        {
            var request = _requestHelper.CreateGetActionRequest(serverID, actionID);

            return Execute<Action>(request);
        }

        #endregion

        #region Domains

        /// <inheritdoc cref="IOneCloudNetClient" />
        public IEnumerable<Domain> GetDomains()
        {
            var request = _requestHelper.CreateGetDomainsRequest();

            return Execute<List<Domain>>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Domain GetDomain(int domainID)
        {
            var request = _requestHelper.CreateGetDomainRequest(domainID);

            return Execute<Domain>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Domain CreateDomain(string name)
        {
            var request = _requestHelper.CreateCreateDomainRequest(name);

            return Execute<Domain>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public bool DeleteDomain(int domainID)
        {
            var request = _requestHelper.CreateDeleteDomainRequest(domainID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Domain CreateARecord(int domainID, string ip, string name, string ttl)
        {
            var request = _requestHelper.CreateCreateARecordRequest(domainID, ip, name, ttl);
            return Execute<Domain>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Domain CreateAAAARecord(int domainID, string ip, string name, string ttl)
        {
            var request = _requestHelper.CreateCreateAAAARecordRequest(domainID, ip, name, ttl);
            return Execute<Domain>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Domain CreateCNAMERecord(int domainID, string name, string mnemonicName, string ttl)
        {
            var request = _requestHelper.CreateCreateCNAMERecordRequest(domainID, name, mnemonicName, ttl);
            return Execute<Domain>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Domain CreateMXRecord(int domainID, string hostname, string priority, string ttl)
        {
            var request = _requestHelper.CreateCreateMXRecordRequest(domainID, hostname, priority, ttl);
            return Execute<Domain>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Domain CreateNSRecord(int domainID, string hostname, string name, string ttl)
        {
            var request = _requestHelper.CreateCreateNSRecordRequest(domainID, hostname, name, ttl);
            return Execute<Domain>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Domain CreateTXTRecord(int domainID, string name, string text, string ttl)
        {
            var request = _requestHelper.CreateCreateTXTRecordRequest(domainID, name, text, ttl);
            return Execute<Domain>(request);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public bool DeleteRecord(int domainID, int recordID)
        {
            var request = _requestHelper.CreateDeleteRecordRequest(domainID, recordID);
            var response = Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public Domain CreateSRVRecord(int domainID, string service, string proto, string name, string priority, string weight, string port, string target, string ttl)
        {
            var request = _requestHelper.CreateCreateSRVRecordRequest(domainID, service, proto, name, priority, weight, port, target, ttl);
            return Execute<Domain>(request);
        }

        #endregion
    }
}
