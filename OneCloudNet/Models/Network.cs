namespace OneCloudNet.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Contains the main info on Public Network.
    /// </summary>
    public class PublicNetwork : PrivateNetwork
    {
        /// <summary>
        /// Gets or sets a network address.
        /// </summary>
        public string CIDR { get; set; }

        /// <summary>
        /// Gets or sets an external address of network gateway.
        /// </summary>
        public string EdgeExternalIp { get; set; }

        /// <summary>
        /// Gets or sets a firewall properties.
        /// </summary>
        public Firewall Firewall { get; set; }

        /// <summary>
        /// Gets or sets VPN properties.
        /// </summary>
        public VPN Vpn { get; set; }
    }

    /// <summary>
    /// Contains the main info on Private Network.
    /// </summary>
    public class PrivateNetwork : Network
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateNetwork" /> class.
        /// </summary>
        public PrivateNetwork()
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
        /// List of connected servers.
        /// </summary>
        public IEnumerable<LinkedServer> LinkedServers { get; set; }

        /// <summary>
        /// Flag whether the DHCP server exists.
        /// </summary>
        public bool IsDHCP { get; set; }

        /// <summary>
        /// Data center location name.
        /// </summary>
        public string DCLocation { get; set; }

        /// <summary>
        /// Network capacity.
        /// </summary>
        public string NetworkCapacity { get; set; }

        /// <summary>
        /// Network type.
        /// </summary>
        public string Type { get; set; }
    }

    /// <summary>
    /// Contains the main info on Network.
    /// </summary>
    public abstract class Network
    {
        /// <summary>
        /// Network mask.
        /// </summary>
        public string Mask { get; set; }

        /// <summary>
        /// Network gateway.
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// Network bandwidth.
        /// </summary>
        public int Bandwidth { get; set; }
    }

    /// <summary>
    /// Contains the main info on network's Linked Server.
    /// </summary>
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

    /// <summary>
    /// Contains the main info on network Firewall.
    /// </summary>
    public class Firewall
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Firewall" /> class.
        /// </summary>
        public Firewall()
        {
            Rules = new List<FirewallRule>();
        }

        /// <summary>
        /// Flag if the firewall is enabled.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Default rule action.
        /// </summary>
        public string DefaultRuleAction { get; set; }

        /// <summary>
        /// List of firewall rules.
        /// </summary>
        public IEnumerable<FirewallRule> Rules { get; set; }
    }

    /// <summary>
    /// Contains the main info on network Firewall Rule.
    /// </summary>
    public class FirewallRule
    {
        /// <summary>
        /// Sequential number of the rule.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// The name of the rule.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Rule action.
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Used protocol (Any, Tcp, Udp, TcpAndUdp, Icmp).
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Source IP address.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Source port.
        /// </summary>
        public string SourcePort { get; set; }

        /// <summary>
        /// Destination IP address.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Destination port.
        /// </summary>
        public string DestinationPort { get; set; }
    }

    /// <summary>
    /// Contains the main info on network VPN.
    /// </summary>
    public class VPN
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VPN" /> class.
        /// </summary>
        public VPN()
        {
            Tunnels = new List<Tunnel>();
        }

        /// <summary>
        /// List of VPN tunnels.
        /// </summary>
        public IEnumerable<Tunnel> Tunnels { get; set; }
    }

    /// <summary>
    /// Contains the main info on VPN Tunnel.
    /// </summary>
    public class Tunnel
    {
        /// <summary>
        /// The unique tunnel ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The state of the tunnel.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The name of the tunnel.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Flag if the tunnel is enabled.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Tunnel MTU.
        /// </summary>
        public int Mtu { get; set; }

        /// <summary>
        /// Encryption type.
        /// </summary>
        public string EncryptionType { get; set; }

        /// <summary>
        /// Shared key.
        /// </summary>
        public string SharedKey { get; set; }

        /// <summary>
        /// Network behind the remote gateway.
        /// </summary>
        public string PeerNetwork { get; set; }

        /// <summary>
        /// IP address of remote gateway.
        /// </summary>
        public string PeerEndpoint { get; set; }

        /// <summary>
        /// External interface of remote gateway.
        /// </summary>
        public string PeerIdentificator { get; set; }
    }
}