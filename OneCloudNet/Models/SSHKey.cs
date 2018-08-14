namespace OneCloudNet.Models
{
    using System;
    using System.Collections.Generic;
    
    public class SSHKey
    {
        public SSHKey()
        {
        }

        /// <summary>
        /// Unique SSHKey ID.
        /// </summary>
        public int ID { get; set; }

        public string Title { get; set; }
        public string PublicKey { get; set; }
        public bool IsActive { get; set; }
    }
}
