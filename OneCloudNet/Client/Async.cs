namespace OneCloudNet.Client
{
    using System;
    using System.Collections.Generic;
    using OneCloudNet.Enums;
    using OneCloudNet.Exceptions;
    using OneCloudNet.Models;
    using Action = OneCloudNet.Models.Action;
    using IRestResponse = RestSharp.IRestResponse;

    /// <summary>
    /// The main 1Cloud API client interface.
    /// Asynchronous methods.
    /// </summary>
    public partial class OneCloudNetClient
    {
        #region Customer

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void Balance(Action<string> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateBalanceRequest();
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Account

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetAccount(Action<Account> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetAccountRequest();

            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Storages

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetStorage(Action<Storage> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetStorageRequest();

            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void ActivateStorage(Action<Storage> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateActivateStorageRequest();

            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void DeactivateStorage(Action<Storage> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeactivateStorageRequest();

            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetStorageUsers(Action<List<StorageUser>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetStorageUsersRequest();

            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateStorageUser(int userName, bool persistPassword, Action<StorageUser> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateStorageUserRequest(userName, persistPassword);

            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetStorageUser(int userID, Action<StorageUser> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetStorageUserRequest(userID);

            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void ChangeStorageUserPassword(int userID, bool persistPassword, Action<StorageUser> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateChangeStorageUserPasswordRequest(userID, persistPassword);

            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void DeleteStorageUser(int userID, Action<StorageUser> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteStorageUserRequest(userID);

            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void BlockStorageUser(int userID, Action<StorageUser> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateBlockStorageUserRequest(userID);

            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void UnblockStorageUser(int userID, Action<StorageUser> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateUnblockStorageUserRequest(userID);

            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Images

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetImages(Action<List<Image>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetImagesRequest();
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateImage(string name, string techName, int serverID, Action<Image> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateImageRequest(name, techName, serverID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void DeleteImage(int imageID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteImageRequest(imageID);
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Private networks

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetNetworks(Action<List<PrivateNetwork>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetPrivateNetworksRequest();
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetNetwork(int networkID, Action<PrivateNetwork> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetPrivateNetworkRequest(networkID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateNetwork(string name, Action<PrivateNetwork> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreatePrivateNetworkRequest(name);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void DeleteNetwork(int networkID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeletePrivateNetworkRequest(networkID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void EditNetwork(int networkID, string name, Action<PrivateNetwork> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateEditPrivateNetworkRequest(networkID, name);
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Public networks

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetPublicNetworks(Action<IEnumerable<PublicNetwork>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetPublicNetworksRequest();
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetPublicNetwork(int networkID, Action<PublicNetwork> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetPublicNetworkRequest(networkID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void OrderPublicNetwork(int networkCapacity, string name, int bandWidth, string dcLocation, Action<PublicNetwork> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateOrderPublicNetworkRequest(networkCapacity, name, bandWidth, dcLocation);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void DeletePublicNetwork(int networkID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeletePublicNetworkRequest(networkID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void EditPublicNetwork(int networkID, int bandWidth, string name, Action<PublicNetwork> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateEditPublicNetworkRequest(networkID, bandWidth, name);
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region DC

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetDCs(Action<List<DC>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetDCsRequest();
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region SSHKey

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetSSHKeys(Action<List<SSHKey>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetSSHKeysRequest();
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetSSHKey(int keyID, Action<SSHKey> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetSSHKeyRequest(keyID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateSSHKey(string title, string publicKey, Action<SSHKey> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateSSHKeyRequest(title, publicKey);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void DeleteSSHKey(int keyID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteSSHKeyRequest(keyID);
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Servers

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetServers(Action<List<Server>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetServersRequest();
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient.GetServer" />
        public void GetServer(int serverID, Action<Server> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetServerRequest(serverID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient.CreateServer" />
        public void CreateServer(string name, int cpu, int ram, int hdd, string imageID, string hddType, bool isHighPerformance, string dcLocation, bool isBackupActive, int backupPeriod, List<int> sshKeys, Action<Server> success, Action<OneCloudException> failure, int? networkID = null, int? networkBandwidth = null, bool? isNeedSysprep = null)
        {
            var request = _requestHelper.CreateCreateServerRequest(name, cpu, ram, hdd, imageID, hddType, isHighPerformance, dcLocation, isBackupActive, backupPeriod, sshKeys, networkID, networkBandwidth, isNeedSysprep);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void ChangeServer(int serverID, int cpu, int ram, int hdd, string hddType, bool isHighPerformance, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateChangeServerRequest(serverID, cpu, ram, hdd, hddType, isHighPerformance);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void DeleteServer(int serverID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteServerRequest(serverID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CopyServer(int serverID, string name, int networkID, Action<Server> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCopyServerRequest(serverID, name, networkID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void RebuildServer(int serverID, int imageID, Action<Server> success, Action<OneCloudException> failure, bool? isNeedSysprep = null)
        {
            var request = _requestHelper.CreateRebuildServerRequest(serverID, imageID, isNeedSysprep);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void PowerServer(int serverID, Power type, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreatePowerServerRequest(serverID, type.ToString());
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void ServerNetwork(int serverID, NetworkAction type, int networkID, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateServerNetworkRequest(serverID, type.ToString(), networkID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void ServerNetworkBandwidth(int serverID, int networkLinkID, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateServerNetworkBandwidthRequest(serverID, NetworkAction.EditNetworkBandwidth.ToString(), networkLinkID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetActions(int serverID, Action<List<Action>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetActionsRequest(serverID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetAction(int serverID, int actionID, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetActionRequest(serverID, actionID);
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Domains

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetDomains(Action<List<Domain>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetDomainsRequest();
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void GetDomain(int domainID, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetDomainRequest(domainID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateDomain(string name, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateDomainRequest(name);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void DeleteDomain(int domainID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteDomainRequest(domainID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateARecord(int domainID, string ip, string name, string ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateARecordRequest(domainID, ip, name, ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateAAAARecord(int domainID, string ip, string name, string ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateAAAARecordRequest(domainID, ip, name, ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateCNAMERecord(int domainID, string name, string mnemonicName, string ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateCNAMERecordRequest(domainID, name, mnemonicName, ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateMXRecord(int domainID, string hostname, string priority, string ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateMXRecordRequest(domainID, hostname, priority, ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateNSRecord(int domainID, string hostname, string name, string ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateNSRecordRequest(domainID, hostname, name, ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateTXTRecord(int domainID, string name, string text, string ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateTXTRecordRequest(domainID, name, text, ttl);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void DeleteRecord(int domainID, int recordID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteRecordRequest(domainID, recordID);
            ExecuteAsync(request, success, failure);
        }

        /// <inheritdoc cref="IOneCloudNetClient" />
        public void CreateSRVRecord(int domainID, string service, string proto, string name, string priority, string weight, string port, string target, string ttl, Action<Domain> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateSRVRecordRequest(domainID, service, proto, name, priority, weight, port, target, ttl);
            ExecuteAsync(request, success, failure);
        }

        #endregion
    }
}
