using System;

namespace OneCloudNet.Models
{
    public class Action
    {
        /// <summary>
        /// Unique action ID.
        /// </summary>
        public Int32 ID { get; set; }

        /// <summary>
        /// Action type. Can be one of these values:
        ///   Create: server creation
        ///   Resize: server config changing
        ///   PowerOn: server power on
        ///   PowerOff: server power off
        ///   PowerReboot: server reboot
        /// </summary>
        public String Type { get; set; }

        /// <summary>
        /// Action state. Can be one of these values:
        /// InProgress: action is in progress
        /// Completed: action completed
        /// Postponed: action postponed
        /// </summary>
        public String State { get; set; }
    }
}
