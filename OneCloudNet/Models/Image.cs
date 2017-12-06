namespace OneCloudNet.Models
{
    using System;
    
    public class Image
    {
        /// <summary>
        /// Unique image ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Image name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Image display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Data center name.
        /// </summary>
        public string DCLocation { get; set; }

        /// <summary>
        /// OS type family ("Linux", "Windows", "Bsd").
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Undocummented property.</remarks>
        public bool IsAvailableISP { get; set; }
    }
}
