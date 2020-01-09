namespace OneCloudNet.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contains the main info on user's Account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        public Account()
        {
            ProjectBalances = new List<ProjectBalance>();
        }

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
        [Obsolete("Deprecated field. Will be removed after 06/01/2020.")]
        public double Balance { get; set; }

        /// <summary>
        /// The date until balance keeps positive.
        /// </summary>
        public DateTime BalanceTillDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the list of common projects.
        /// </summary>
        public IEnumerable<ProjectBalance> ProjectBalances { get; set; }
    }

    /// <summary>
    /// Contains project's info with detailed balance.
    /// </summary>
    public class ProjectBalance
    {
        /// <summary>
        /// Gets or sets unique project's Id.
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// Gets or sets project's balance info.
        /// </summary>
        public Balance Balance { get; set; }
    }

    /// <summary>
    /// Contains detailed project's balance info.
    /// </summary>
    public class Balance
    {
        /// <summary>
        /// Gets or sets an amount of real money.
        /// </summary>
        public double Real { get; set; }

        /// <summary>
        /// Gets or sets an amount of bonus.
        /// </summary>
        public double Bonus { get; set; }

        /// <summary>
        /// Gets or sets an amount of test money.
        /// </summary>
        public double Test { get; set; }
    }
}