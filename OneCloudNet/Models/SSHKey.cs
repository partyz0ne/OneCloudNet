namespace OneCloudNet.Models
{
    /// <summary>
    /// Contains the main info on SSH Key.
    /// </summary>
    public class SSHKey
    {
        /// <summary>
        /// Unique SSHKey ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The key's name.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The key's content.
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// The flag whether the key is active.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
