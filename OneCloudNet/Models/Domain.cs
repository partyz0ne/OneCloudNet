using System;
using System.Collections.Generic;

namespace OneCloudNet.Models
{
    public class Domain
    {
        /// <summary>
        /// Unique ID.
        /// </summary>
        public Int32 ID { get; set; }

        /// <summary>
        /// Name of domain.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Technical name of domain.
        /// </summary>
        public String TechName { get; set; }

        /// <summary>
        /// Curretn state.
        /// </summary>
        public String State { get; set; }

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
        public Int32 ID { get; set; }

        /// <summary>
        /// Record type:
        ///  A, AAAA, MX, CNAME, TXT, NS.
        /// </summary>
        public String TypeRecord { get; set; }

        /// <summary>
        /// IP address.
        /// </summary>
        public String IP { get; set; }

        /// <summary>
        /// Hostname.
        /// "@" - if the record is created for domain, or subdomain name if the record is created for it.
        /// </summary>
        public String HostName { get; set; }

        /// <summary>
        /// Record priority (acceptable only for MX-records).
        /// </summary>
        public String Priority { get; set; }

        /// <summary>
        /// Record text (acceptable only for MX-records).
        /// </summary>
        public String Text { get; set; }

        /// <summary>
        /// Mnemonic name (acceptable only for CNAME-records).
        /// </summary>
        public String MnemonicName { get; set; }

        /// <summary>
        /// Name of external host name (acceptable only for MX- or NS-records).
        /// </summary>
        public String ExtHostName { get; set; }

        /// <summary>
        /// Current record state.
        ///  New - for creating;
        ///  Active - for active.
        /// </summary>
        public String State { get; set; }
    }
}