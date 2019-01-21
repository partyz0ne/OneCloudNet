namespace OneCloudNet.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contains the main info on Domain.
    /// </summary>
    public class Domain
    {
        /// <summary>
        /// Gets or sets unique ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets name of domain.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets technical name of domain.
        /// </summary>
        public string TechName { get; set; }

        /// <summary>
        /// Gets or sets current state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Creation date of domain.
        /// </summary>
        public DateTime DateCreate { get; set; }

        /// <summary>
        /// List of domain records.
        /// </summary>
        public IEnumerable<DomainRecord> LinkedRecords { get; set; }
    }

    /// <summary>
    /// Contains the main info on Domain Record.
    /// </summary>
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
        /// Port of working service (for SRV-records).
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
        /// Current record state.
        ///  New - for creating;
        ///  Active - for active.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Canonical description of the record.
        /// </summary>
        public string CanonicalDescription { get; set; }
    }
}