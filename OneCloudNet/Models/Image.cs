using System;

namespace OneCloudNet.Models
{
    public class Image
    {
        /// <summary>
        /// Unique image ID.
        /// </summary>
        public Int32 ID { get; set; }

        /// <summary>
        /// Image name.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Image display name.
        /// </summary>
        public String DisplayName { get; set; }

        /// <summary>
        /// Data center name.
        /// </summary>
        public String DCLocation { get; set; }

        /// <summary>
        /// OS type family ("Linux", "Windows", "Bsd").
        /// </summary>
        public String Family { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Undocummented property.</remarks>
        public Boolean IsAvailableISP { get; set; }
    }
}
