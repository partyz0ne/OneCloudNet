using System;
using System.Collections.Generic;
using System.Net;
using OneCloudNet.Enums;
using OneCloudNet.Exceptions;
using OneCloudNet.Models;
using RestSharp;
using Action = OneCloudNet.Models.Action;

namespace OneCloudNet.Client
{
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
        void Balance(Action<String> success, Action<OneCloudException> failure);

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
        void CreateImage(String name, String techName, Int32 serverID, Action<Image> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete image.
        /// </summary>
        /// <param name="imageID">Image ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteImage(Int32 imageID, Action<IRestResponse> success, Action<OneCloudException> failure);

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
        void GetNetwork(Int32 networkID, Action<Network> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create new network.
        /// </summary>
        /// <param name="name">Network name.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateNetwork(String name, Action<Network> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteNetwork(Int32 networkID, Action<IRestResponse> success, Action<OneCloudException> failure);

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
        void GetServer(Int32 serverID, Action<Server> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create new server.
        /// </summary>
        /// <param name="name">Server name.</param>
        /// <param name="cpu">Number of CPU.</param>
        /// <param name="ram">Volume of RAM (Mb).</param>
        /// <param name="hdd">Hard disk space (Gb).</param>
        /// <param name="imageID">Initial image ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateServer(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID, Action<Server> success, Action<OneCloudException> failure);

        /// <summary>
        /// Change server configuration.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="cpu">Number of CPU.</param>
        /// <param name="ram">Volume of RAM (Mb).</param>
        /// <param name="hdd">Hard disk space (Gb).</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void ChangeServer(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd, Action<Action> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteServer(Int32 serverID, Action<IRestResponse> success, Action<OneCloudException> failure);

        /// <summary>
        /// Action for power server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="type">Type of action.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void PowerServer(Int32 serverID, Power type, Action<Action> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get list of active actions for server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetActions(Int32 serverID, Action<List<Action>> success, Action<OneCloudException> failure);

        /// <summary>
        /// Get information about action by ID.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="actionID">Action ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetAction(Int32 serverID, Int32 actionID, Action<Action> success, Action<OneCloudException> failure);

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
        void GetDomain(Int32 domainID, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create new domain.
        /// </summary>
        /// <param name="name">Domain name.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateDomain(String name, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteDomain(Int32 domainID, Action<IRestResponse> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXX.XXX.XXX.XXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateARecord(Int32 domainID, String ip, String name, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateAAAARecord(Int32 domainID, String ip, String name, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Canonical name or @ symbol.</param>
        /// <param name="mnemonicName">Mnemonic name.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateCNAMERecord(Int32 domainID, String name, String mnemonicName, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostname">Domain name.</param>
        /// <param name="priority">Record priority.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateMXRecord(Int32 domainID, String hostname, String priority, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Domain name.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateNSRecord(Int32 domainID, String name, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="text">Text.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void CreateTXTRecord(Int32 domainID, String name, String text, Action<Domain> success, Action<OneCloudException> failure);

        /// <summary>
        /// Delete record for domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="recordID">Record ID.</param>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void DeleteRecord(Int32 domainID, Int32 recordID, Action<IRestResponse> success, Action<OneCloudException> failure);

        #endregion

        #endregion

        #region Synchronious requests

        #region Customer

        /// <summary>
        /// Get account balance.
        /// </summary>
        /// <returns>Current balance.</returns>
        String Balance();

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
        Image CreateImage(String name, String techName, Int32 serverID);

        /// <summary>
        /// Delete image.
        /// </summary>
        /// <param name="imageID">Image ID.</param>
        /// <returns>Result of operation.</returns>
        Boolean DeleteImage(Int32 imageID);

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
        Network GetNetwork(Int32 networkID);

        /// <summary>
        /// Create new network.
        /// </summary>
        /// <param name="name">Network name.</param>
        /// <returns>Created network information.</returns>
        Network CreateNetwork(String name);

        /// <summary>
        /// Delete network.
        /// </summary>
        /// <param name="networkID">Network ID.</param>
        /// <returns>Result of operation.</returns>
        Boolean DeleteNetwork(Int32 networkID);

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
        Server GetServer(Int32 serverID);

        /// <summary>
        /// Create new server.
        /// </summary>
        /// <param name="name">Server name.</param>
        /// <param name="cpu">Number of CPU.</param>
        /// <param name="ram">Volume of RAM (Mb).</param>
        /// <param name="hdd">Hard disk space (Gb).</param>
        /// <param name="imageID">Initial image ID.</param>
        /// <returns>Created server information.</returns>
        Server CreateServer(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID);

        /// <summary>
        /// Change server configuration.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="cpu">Number of CPU.</param>
        /// <param name="ram">Volume of RAM (Mb).</param>
        /// <param name="hdd">Hard disk space (Gb).</param>
        /// <returns>Action, caused by changing operation.</returns>
        Action ChangeServer(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd);

        /// <summary>
        /// Delete server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <returns>Result of operation.</returns>
        Boolean DeleteServer(Int32 serverID);

        /// <summary>
        /// Action for power server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="type">Type of action.</param>
        /// <returns>Action, caused by operation.</returns>
        Action PowerServer(Int32 serverID, Power type);
        
        /// <summary>
        /// Get list of active actions for server.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <returns>List of operations.</returns>
        IEnumerable<Action> GetActions(Int32 serverID);

        /// <summary>
        /// Get information about action by ID.
        /// </summary>
        /// <param name="serverID">Server ID.</param>
        /// <param name="actionID">Action ID.</param>
        /// <returns>Action information.</returns>
        Action GetAction(Int32 serverID, Int32 actionID);

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
        Domain GetDomain(Int32 domainID);

        /// <summary>
        /// Create new domain.
        /// </summary>
        /// <param name="name">Domain name.</param>
        /// <returns>Created domain information.</returns>
        Domain CreateDomain(String name);

        /// <summary>
        /// Delete domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <returns>Result of operation.</returns>
        Boolean DeleteDomain(Int32 domainID);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXX.XXX.XXX.XXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <returns></returns>
        Domain CreateARecord(Int32 domainID, String ip, String name);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="ip">IP-address in XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX format.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <returns></returns>
        Domain CreateAAAARecord(Int32 domainID, String ip, String name);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Canonical name or @ symbol.</param>
        /// <param name="mnemonicName">Mnemonic name.</param>
        /// <returns></returns>
        Domain CreateCNAMERecord(Int32 domainID, String name, String mnemonicName);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="hostname">Domain name.</param>
        /// <param name="priority">Record priority.</param>
        /// <returns></returns>
        Domain CreateMXRecord(Int32 domainID, String hostname, String priority);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Domain name.</param>
        /// <returns></returns>
        Domain CreateNSRecord(Int32 domainID, String name);

        /// <summary>
        /// Create A-record.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="name">Domain name or @ symbol.</param>
        /// <param name="text">Text.</param>
        /// <returns></returns>
        Domain CreateTXTRecord(Int32 domainID, String name, String text);

        /// <summary>
        /// Delete record for domain.
        /// </summary>
        /// <param name="domainID">Domain ID.</param>
        /// <param name="recordID">Record ID.</param>
        /// <returns>Result of operation.</returns>
        Boolean DeleteRecord(Int32 domainID, Int32 recordID);

        #endregion

        #endregion
    }
}