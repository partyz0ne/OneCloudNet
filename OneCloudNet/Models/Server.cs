namespace OneCloudNet.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Server
    {
        public Server()
        {
            LinkedNetworks = new List<LinkedNetwork>();
        }

        /// <summary>
        /// Unique server ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// User's server name, entered at creation.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Server state at the moment of request handling. Can be one of these values:
        /// New: server creating
        /// Active: server is created
        /// Blocked: server is blocked as negative account bill
        /// NeedMoney: server is not created as not enough money
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Server power state at the moment of request handling. Can be one of these values:
        /// true: server power is on
        /// false: server power is off
        /// </summary>
        public bool IsPowerOn { get; set; }

        /// <summary>
        /// Number of processor cores
        /// </summary>
        public int CPU { get; set; }

        /// <summary>
        /// RAM volume (Mb).
        /// </summary>
        public int RAM { get; set; }

        /// <summary>
        /// Hard disk space (Gb).
        /// </summary>
        public int HDD { get; set; }

        /// <summary>
        /// External IPv4 address.
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// Admin username.
        /// </summary>
        public string AdminUserName { get; set; }

        /// <summary>
        /// Admin password.
        /// </summary>
        public string AdminPassword { get; set; }

        /// <summary>
        /// Inital server image.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// True if server is in highperformance pool, false - in basic pool.
        /// </summary>
        public bool IsHighPerformance { get; set; }

        /// <summary>
        /// Type of server HDD ("SAS", "SSD").
        /// </summary>
        public string HDDType { get; set; }

        /// <summary>
        /// List of connected networks.
        /// </summary>
        public List<LinkedNetwork> LinkedNetworks { get; set; }

        /// <summary>
        /// Name of hosting data center.
        /// </summary>
        public string DCLocation { get; set; }

        /// <summary>
        /// Type of server OS.
        /// </summary>
        public string ImageFamily { get; set; }
    }

    public class LinkedNetwork
    {
        /// <summary>
        /// Network ID.
        /// </summary>
        public int NetworkID { get; set; }

        /// <summary>
        /// Server IP-address.
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// Server MAC-address.
        /// </summary>
        public string MAC { get; set; }
    }
}
