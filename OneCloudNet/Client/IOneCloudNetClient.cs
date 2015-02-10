using System;
using System.Collections.Generic;
using System.Net;
using OneCloudNet.Exceptions;
using OneCloudNet.Models;
using Action = OneCloudNet.Models.Action;

namespace OneCloudNet.Client
{
    public interface IOneCloudNetClient
    {
        IWebProxy Proxy { get; set; }

        #region Asynchronious requests

        void GetImages(Action<List<Image>> success, Action<OneCloudException> failure);

        void GetServers(Action<List<Server>> success, Action<OneCloudException> failure);

        void GetServer(Int32 serverID, Action<Server> success, Action<OneCloudException> failure);

        void CreateServer(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID, Action<Server> success, Action<OneCloudException> failure);

        void ChangeServer(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd, Action<Action> success, Action<OneCloudException> failure);

        void DeleteServer(Int32 serverID, Action<Boolean> success, Action<OneCloudException> failure);

        void PowerServer(Int32 serverID, String type, Action<Action> success, Action<OneCloudException> failure);

        void GetActions(Int32 serverID, Action<List<Action>> success, Action<OneCloudException> failure);

        void GetAction(Int32 serverID, Int32 actionID, Action<Action> success, Action<OneCloudException> failure);

        #endregion

        #region Synchronious requests

        IEnumerable<Image> GetImages();

        IEnumerable<Server> GetServers();

        Server GetServer(Int32 serverID);

        Server CreateServer(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID);

        Action ChangeServer(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd);

        Boolean DeleteServer(Int32 serverID);

        Action PowerServer(Int32 serverID, String type);
        
        IEnumerable<Action> GetActions(Int32 serverID);

        Action GetAction(Int32 serverID, Int32 actionID);

        #endregion
    }
}