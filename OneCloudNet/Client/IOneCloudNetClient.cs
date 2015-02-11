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
        /// <summary>
        /// Proxy settings.
        /// </summary>
        IWebProxy Proxy { get; set; }

        #region Asynchronious requests

        /// <summary>
        /// Get list of images.
        /// </summary>
        /// <param name="success">Callback for successfull result.</param>
        /// <param name="failure">Callback for failure.</param>
        void GetImages(Action<List<Image>> success, Action<OneCloudException> failure);

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

        #region Synchronious requests

        /// <summary>
        /// Get list of images.
        /// </summary>
        /// <returns>List of images.</returns>
        IEnumerable<Image> GetImages();

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
    }
}