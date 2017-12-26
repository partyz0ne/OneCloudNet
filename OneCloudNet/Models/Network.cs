namespace OneCloudNet.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Network
    {
        /// <summary>
        /// Private network constructor.
        /// </summary>
        public Network()
        {
            LinkedServers = new List<LinkedServer>();
        }
        
        /// <summary>
        /// Private network unique ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Network name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Network state. Can contain such values as:
        ///  "New" - network is being created;
        ///  "Active" - network is created;
        ///  "NeedMoney" - not enough money for creating.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Network mask.
        /// </summary>
        public string Mask { get; set; }

        /// <summary>
        /// Network gateway.
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// List of connected servers.
        /// </summary>
        public List<LinkedServer> LinkedServers { get; set; }
    }

    public class LinkedServer
    {
        /// <summary>
        /// IP-address of server.
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// MAC-address of server.
        /// </summary>
        public string MAC { get; set; }

        /// <summary>
        /// Server unique ID.
        /// </summary>
        public int ServerID { get; set; }
    }
}