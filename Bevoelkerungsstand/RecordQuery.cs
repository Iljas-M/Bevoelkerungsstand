using System;
using System.Collections.Generic;

namespace Bevoelkerungsstand
{
    /// <summary>
    /// The Record Query Class.
    /// </summary>
    internal class RecordQuery
    {
        /// <summary>
        /// Create new data evalatuion.
        /// </summary>
        private DataEvaluation dataEvaluation;

        /// <summary>
        /// Get federal state colletion.
        /// </summary>
        public List<FederalState> federalStateList;

        /// <summary>
        /// Get population date colletion.
        /// </summary>
        public List<DateTime> populationDateList;

        /// <summary>
        /// The reacord query.
        /// </summary>
        public RecordQuery ()
        {
            // Init.
            this.dataEvaluation = new DataEvaluation();
            this.federalStateList = this.dataEvaluation.GetFederalSateCollection();
            this.populationDateList = this.dataEvaluation.GetPopulationDateCollection();   
        }

        /// <summary>
        /// The Year State Filter.
        /// </summary>
        /// <param name="federalStateName"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public string YearStateFilter(string federalStateName, DateTime year)
        {
            string result = string.Empty;

            foreach (var federalState in this.federalStateList)
            {
                if (federalState.Name.Contains(federalStateName))
                {
                    foreach (var population in federalState.PopulationLevel)
                    {
                        if (population.Year.Equals(year))
                        {
                            result = $"{population.MaleAmount};{population.FemaleAmount};{population.TotalAmount}";
                            return result;
                        }
                    }
                }
            }

            return result;

        }
    }
}
