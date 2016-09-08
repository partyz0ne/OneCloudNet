using System;
using System.Collections.Generic;

namespace OneCloudNet.Models
{
    public class Server
    {
        /// <summary>
        /// Unique server ID.
        /// </summary>
        public Int32 ID { get; set; }

        /// <summary>
        /// User's server name, entered at creation.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Server state at the moment of request handling. Can be one of these values:
        /// New: server creating
        /// Active: server is created
        /// Blocked: server is blocked as negative account bill
        /// NeedMoney: server is not created as not enough money
        /// </summary>
        public String State { get; set; }

        /// <summary>
        /// Server power state at the moment of request handling. Can be one of these values:
        /// true: server power is on
        /// false: server power is off
        /// </summary>
        public Boolean IsPowerOn { get; set; }

        /// <summary>
        /// Number of processor cores
        /// </summary>
        public Int32 CPU { get; set; }

        /// <summary>
        /// RAM volume (Mb).
        /// </summary>
        public Int32 RAM { get; set; }

        /// <summary>
        /// Hard disk space (Gb).
        /// </summary>
        public Int32 HDD { get; set; }

        /// <summary>
        /// External IPv4 address.
        /// </summary>
        public String IP { get; set; }

        /// <summary>
        /// Admin username.
        /// </summary>
        public String AdminUserName { get; set; }

        /// <summary>
        /// Admin password.
        /// </summary>
        public String AdminPassword { get; set; }

        /// <summary>
        /// Inital server image.
        /// </summary>
        public String Image { get; set; }

        /// <summary>
        /// True if server is in highperformance pool, false - in basic pool.
        /// </summary>
        public Boolean IsHighPerformance { get; set; }

        /// <summary>
        /// Type of server HDD ("SAS", "SSD").
        /// </summary>
        public String HDDType { get; set; }

        /// <summary>
        /// List of connected networks.
        /// </summary>
        public List<LinkedNetwork> LinkedNetworks { get; set; }

        /// <summary>
        /// Name of hosting data center.
        /// </summary>
        public String DCLocation { get; set; }

        /// <summary>
        /// Type of server OS.
        /// </summary>
        public String ImageFamily { get; set; }

        public Server()
        {
            LinkedNetworks = new List<LinkedNetwork>();
        }
    }

    public class LinkedNetwork
    {
        /// <summary>
        /// Network ID.
        /// </summary>
        public Int32 NetworkID { get; set; }

        /// <summary>
        /// Server IP-address.
        /// </summary>
        public String IP { get; set; }

        /// <summary>
        /// Server MAC-address.
        /// </summary>
        public String MAC { get; set; }
    }
}
