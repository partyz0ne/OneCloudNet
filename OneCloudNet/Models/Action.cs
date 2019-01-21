namespace OneCloudNet.Models
{
    using System;

    /// <summary>
    /// Contains the main info on Action with server.
    /// </summary>
    public class Action
    {
        /// <summary>
        /// Gets or sets unique action ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets an action type. Can be one of these values:
        ///   Create: server creation
        ///   Resize: server config changing
        ///   PowerOn: server power on
        ///   PowerOff: server power off
        ///   PowerReboot: server reboot
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets an action state. Can be one of these values:
        /// InProgress: action is in progress
        /// Completed: action completed
        /// Postponed: action postponed
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the start date of an action.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the finish date of an action.
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
