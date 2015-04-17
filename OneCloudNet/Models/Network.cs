using System;
using System.Collections.Generic;

namespace OneCloudNet.Models
{
    public class Network
    {
        /// <summary>
        /// Private network unique ID.
        /// </summary>
        public Int32 ID { get; set; }

        /// <summary>
        /// Network name.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Network state. Can contain such values as:
        ///  "New" - network is being created;
        ///  "Active" - network is created;
        ///  "NeedMoney" - not enough money for creating.
        /// </summary>
        public String State { get; set; }

        /// <summary>
        /// Network mask.
        /// </summary>
        public String Mask { get; set; }

        /// <summary>
        /// Network gateway.
        /// </summary>
        public String Gateway { get; set; }

        /// <summary>
        /// List of connected servers.
        /// </summary>
        public List<LinkedServer> LinkedServers { get; set; }

        /// <summary>
        /// Private network constructor.
        /// </summary>
        public Network()
        {
            LinkedServers = new List<LinkedServer>();
        }
    }

    public class LinkedServer
    {
        /// <summary>
        /// IP-address of server.
        /// </summary>
        public String IP { get; set; }

        /// <summary>
        /// MAC-address of server.
        /// </summary>
        public String MAC { get; set; }

        /// <summary>
        /// Server unique ID.
        /// </summary>
        public Int32 ServerID { get; set; }
    }
}