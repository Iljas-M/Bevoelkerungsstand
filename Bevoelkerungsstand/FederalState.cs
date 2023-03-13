using System.Collections.Generic;

namespace Bevoelkerungsstand
{
    /// <summary>
    /// The federal state Class.
    /// </summary>
    internal class FederalState
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets or sets the population level list.
        /// </summary>
        public List<Population> PopulationLevel { get; set; }

        /// <summary>
        /// The federal state.
        /// </summary>
        /// <param name="name"></param>
        public FederalState(string name)
        {
            this.Name = name;
            this.PopulationLevel = new List<Population>();
        }
    }
}