namespace OneCloudNet.Models
{
    using System;

    /// <summary>
    /// Contains the main info on user's Account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Unique ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// User firstname.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// User lastname.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// User e-mail.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Current billing balance.
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// The date until balance keeps positive.
        /// </summary>
        public DateTime BalanceTillDateUtc { get; set; }
    }
}