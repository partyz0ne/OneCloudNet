namespace OneCloudNet.Models
{
    /// <summary>
    /// Contains the main info on Data Center.
    /// </summary>
    public class DC
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Technical name.
        /// </summary>
        public string TechTitle { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Short name.
        /// </summary>
        public string ShortTitle { get; set; }

        /// <summary>
        /// Is base type device available.
        /// </summary>
        public bool IsEnableLowPool { get; set; }

        /// <summary>
        /// Is high power device available.
        /// </summary>
        public bool IsEnableHighPool { get; set; }

        /// <summary>
        /// Is backup available.
        /// </summary>
        public bool IsEnableBackup { get; set; }

        /// <summary>
        /// Is IPv6 available.
        /// </summary>
        public bool IsEnableIpV6 { get; set; }
    }
}