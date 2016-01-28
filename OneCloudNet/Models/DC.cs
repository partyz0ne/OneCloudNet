using System;

namespace OneCloudNet.Models
{
    public class DC
    {
        /// <summary>
        /// Technical name.
        /// </summary>
        public String TechTitle { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// Short name.
        /// </summary>
        public String ShortTitle { get; set; }

        /// <summary>
        /// Is base type device available.
        /// </summary>
        public Boolean IsEnableLowPool { get; set; }

        /// <summary>
        /// Is high power device available.
        /// </summary>
        public Boolean IsEnableHighPool { get; set; }
    }
}