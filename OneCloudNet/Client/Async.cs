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
        #region Images

        public void GetImages(Action<List<Image>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetImagesRequest();
            ExecuteAsync(request, success, failure);
        }

        public void CreateImage(String name, String techName, Int32 serverID, Action<Image> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateImageRequest(name, techName, serverID);
            ExecuteAsync(request, success, failure);
        }

        public void DeleteImage(Int32 imageID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteImageRequest(imageID);
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Private networks

        public void GetNetworks(Action<List<Network>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetNetworksRequest();
            ExecuteAsync(request, success, failure);
        }

        public void GetNetwork(Int32 networkID, Action<Network> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetNetworkRequest(networkID);
            ExecuteAsync(request, success, failure);
        }

        public void CreateNetwork(String name, Action<Network> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateNetworkRequest(name);
            ExecuteAsync(request, success, failure);
        }

        public void DeleteNetwork(Int32 networkID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteNetworkRequest(networkID);
            ExecuteAsync(request, success, failure);
        }

        #endregion

        #region Servers

        public void GetServers(Action<List<Server>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetServersRequest();
            ExecuteAsync(request, success, failure);
        }

        public void GetServer(Int32 serverID, Action<Server> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetServerRequest(serverID);
            ExecuteAsync(request, success, failure);
        }

        public void CreateServer(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID, Action<Server> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateCreateServerRequest(name, cpu, ram, hdd, imageID);
            ExecuteAsync(request, success, failure);
        }

        public void ChangeServer(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateChangeServerRequest(serverID, cpu, ram, hdd);
            ExecuteAsync(request, success, failure);
        }

        public void DeleteServer(Int32 serverID, Action<IRestResponse> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateDeleteServerRequest(serverID);
            ExecuteAsync(request, success, failure);
        }

        public void PowerServer(Int32 serverID, Power type, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreatePowerServerRequest(serverID, type.ToString());
            ExecuteAsync(request, success, failure);
        }

        public void GetActions(Int32 serverID, Action<List<Action>> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetActionsRequest(serverID);
            ExecuteAsync(request, success, failure);
        }

        public void GetAction(Int32 serverID, Int32 actionID, Action<Action> success, Action<OneCloudException> failure)
        {
            var request = _requestHelper.CreateGetActionRequest(serverID, actionID);
            ExecuteAsync(request, success, failure);
        }

        #endregion
    }
}
