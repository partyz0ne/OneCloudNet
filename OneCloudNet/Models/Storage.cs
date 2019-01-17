namespace OneCloudNet.Models
{
    /// <summary>
    /// Contains the main info on Storage.
    /// </summary>
    public class Storage
    {
        /// <summary>
        /// The unique storage ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The unique ID in swift system.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Storage name.
        /// </summary>
        /// <remarks>Equals to its Id by default.</remarks>
        public string Name { get; set; }

        /// <summary>
        /// Available disk quota.
        /// </summary>
        /// <remarks>Null by default.</remarks>
        public int? QuotaBytes { get; set; }

        /// <summary>
        /// Storage state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Storage owner.
        /// </summary>
        public StorageUser Owner { get; set; }

        /// <summary>
        /// Tasks of the storage.
        /// </summary>
        public object Tasks { get; set; }
    }

    /// <summary>
    /// Contains the main info on Storage Owner.
    /// </summary>
    public class StorageUser
    {
        /// <summary>
        /// The unique owner ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The unique ID in swift system.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Owner login.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Owner password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Data for connection to storage via Swift API.
        /// </summary>
        public object SwiftApiConnection { get; set; }

        /// <summary>
        /// Data for connection to storage via Amazon S3 API.
        /// </summary>
        public object S3Connection { get; set; }

        /// <summary>
        /// Data for connection to storage via FTP protocol.
        /// </summary>
        public object FtpConnection { get; set; }

        /// <summary>
        /// The state of owner's account.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The object describing current tasks.
        /// </summary>
        public object Tasks { get; set; }
    }
}
