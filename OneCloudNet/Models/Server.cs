namespace OneCloudNet.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Contains the main info on Server.
    /// </summary>
    public class Server
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Server" /> class.
        /// </summary>
        public Server()
        {
            LinkedNetworks = new List<LinkedNetwork>();
            LinkedSshKeys = new List<SSHKey>();
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
        /// IP address of the main network interface.
        /// </summary>
        public string PrimaryNetworkIp { get; set; }

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

        /// <summary>
        /// List of associated SSH keys.
        /// </summary>
        public List<SSHKey> LinkedSshKeys { get; set; }
    }

    /// <summary>
    /// Contains the main info on server's Linked Network.
    /// </summary>
    public class LinkedNetwork : Network
    {
        /// <summary>
        /// Unique connection ID.
        /// </summary>
        public int LinkID { get; set; }

        /// <summary>
        /// Network ID.
        /// </summary>
        public int NetworkID { get; set; }

        /// <summary>
        /// The state of connection.
        /// </summary>
        public string LinkState { get; set; }

        /// <summary>
        /// Network type.
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Network name.
        /// </summary>
        public string NetworkName { get; set; }

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
