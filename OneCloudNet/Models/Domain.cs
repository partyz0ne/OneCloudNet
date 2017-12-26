namespace OneCloudNet.Models
{
    using System;
    using System.Collections.Generic;

    public class Domain
    {
        /// <summary>
        /// Unique ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of domain.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Technical name of domain.
        /// </summary>
        public string TechName { get; set; }

        /// <summary>
        /// Curretn state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Creation date of domain.
        /// </summary>
        public DateTime DateCreate { get; set; }

        /// <summary>
        /// List of domain records.
        /// </summary>
        public List<DomainRecord> LinkedRecords { get; set; } 
    }

    public class DomainRecord
    {
        /// <summary>
        /// Unique ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Record type:
        ///  A, AAAA, MX, CNAME, TXT, NS.
        /// </summary>
        public string TypeRecord { get; set; }

        /// <summary>
        /// IP address.
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// Hostname.
        /// "@" - if the record is created for domain, or subdomain name if the record is created for it.
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// Record priority (acceptable only for MX-records).
        /// </summary>
        public string Priority { get; set; }

        /// <summary>
        /// Record text (acceptable only for MX-records).
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Mnemonic name (acceptable only for CNAME-records).
        /// </summary>
        public string MnemonicName { get; set; }

        /// <summary>
        /// Name of external host name (acceptable only for MX- or NS-records).
        /// </summary>
        public string ExtHostName { get; set; }

        /// <summary>
        /// Weight of records with equal priority (for SRV-records).
        /// </summary>
        public string Weight { get; set; }

        /// <summary>
        /// Port of workign service (for SRV-records).
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// Canonical computer name of service (for SRV-records).
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// Transport service protocol (for SRV-records).
        /// </summary>
        public string Proto { get; set; }

        /// <summary>
        /// Service name (for SRV-records).
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Time to live (in seconds).
        /// </summary>
        public string TTL { get; set; }

        /// <summary>
        /// Current record state.
        ///  New - for creating;
        ///  Active - for active.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Creation date of record.
        /// </summary>
        public DateTime DateCreate { get; set; }
    }
}