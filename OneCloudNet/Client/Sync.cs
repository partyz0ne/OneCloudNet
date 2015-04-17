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

        public Server CreateServer(String name, Int32 cpu, Int32 ram, Int32 hdd, String imageID)
        {
            var request = _requestHelper.CreateCreateServerRequest(name, cpu, ram, hdd, imageID);

            return Execute<Server>(request);
        }

        public Action ChangeServer(Int32 serverID, Int32 cpu, Int32 ram, Int32 hdd)
        {
            var request = _requestHelper.CreateChangeServerRequest(serverID, cpu, ram, hdd);

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
    }
}
