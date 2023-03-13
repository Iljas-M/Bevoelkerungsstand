using System;

namespace Bevoelkerungsstand
{
    /// <summary>
    /// The Population Class.
    /// </summary>
    internal class Population
    {
        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        public DateTime Year { get; set; }

        /// <summary>
        /// Gets or sets the male amount.
        /// </summary>
        public long MaleAmount { get; set; }

        /// <summary>
        /// Gets or sets the female amount.
        /// </summary>
        public long FemaleAmount { get; set; }

        /// <summary>
        /// Gets or sets the total amount.
        /// </summary>
        public long TotalAmount { get; set; }
    }
}