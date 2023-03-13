using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bevoelkerungsstand
{
    /// <summary>
    /// The Data Evaluation Class.
    /// </summary>
    internal class DataEvaluation
    {
        /// <summary>
        /// The csv content.
        /// </summary>
        private List<string> csvContent;

        /// <summary>
        /// The federal state collection.
        /// </summary>
        private List<FederalState> federalStateList;

        /// <summary>
        /// The gender collection.
        /// </summary>
        private List<Gender> genderList;

        /// <summary>
        /// The population.
        /// </summary>
        private Population population;

        /// <summary>
        /// The population dates colletion.
        /// </summary>
        private List<DateTime> populationDateList;

        /// <summary>
        /// The Data Evaluation.
        /// </summary>
        public DataEvaluation ()
        {
            // Init.
            this.csvContent = ReadCsv(Constants.PathToCsvFileData);
            this.federalStateList = new List<FederalState>();
            this.genderList = new List<Gender>();
            this.population = new Population();
            this.populationDateList = new List<DateTime>();

            // Customize csv.
            CustomizeCsv();
        }

        /// <summary>
        /// Adjust and feel csv data.
        /// </summary>
        private void CustomizeCsv()
        {
            // Init.
            int amountOfContent = 0;
            int genderSwitchCounter = 0;
            int federalStateCounter = 0;
            DateTime tempSaveDateTime = DateTime.MinValue;

            if (csvContent != null)
            {
                amountOfContent = csvContent.Count;
            }

            // 0. Check if the csv has content.
            if (amountOfContent > 0)
            {
                // 1. Go through the single rows of csv content.
                for (int row = 0; row < amountOfContent; row++)
                {
                    // 2. Split the csv content.
                    string[] splitedColumns = csvContent[row].Split(';');

                    // 2.1 Cancel as soon as the last line comes.
                    if (splitedColumns.Contains("__________"))
                    {
                        break;
                    }

                    // 3. Go through the single columns.
                    for (int col = 0; col < splitedColumns.Length; col++)
                    {
                        // Save temp the culumn content.
                        string columnContent = splitedColumns[col];

                        // 4. Skip whitespaces.
                        if (columnContent != string.Empty)
                        {
                            // 5 Pull out the federal states from the fifth line.
                            if (row == 5)
                            {
                                // 5.1 Create and Add federal state.
                                FederalState newFederalState = new FederalState(columnContent);

                                // 5.2 Check if the federal state already contains.
                                if (this.federalStateList.Find(element => element.Name.Equals(newFederalState.Name)) == null)
                                {
                                    this.federalStateList.Add(newFederalState);
                                }
                            }

                            // 6. Pull out the gender from the sixth line.
                            if (row == 6)
                            {
                                // 6.1 Create and Add gender.
                                Gender newGender = new Gender(columnContent);

                                // 6.2 Check if the gender already contains.
                                if (this.genderList.Find(element => element.Name.Equals(newGender.Name)) == null)
                                {
                                    this.genderList.Add(newGender);
                                }
                            }

                            // 7. Pull out the amount of gender,year and total from all other lines.
                            if (row >= 7)
                            {
                                // 7.1 The first column is always the year.
                                if (col == 0)
                                {
                                    // Reset counters.
                                    federalStateCounter = 0;
                                    genderSwitchCounter = 0;

                                    tempSaveDateTime = DateTime.Parse(columnContent);
                                    this.populationDateList.Add(tempSaveDateTime);
                                }
                                else
                                {
                                    // 7.2 Add the individual columns in the order "male, female, total".
                                    switch (genderSwitchCounter)
                                    {
                                        case 1: this.population.MaleAmount = long.Parse(columnContent);
                                            break;
                                        case 2: this.population.FemaleAmount = long.Parse(columnContent);
                                            break ;
                                        case 3: this.population.TotalAmount = long.Parse(columnContent);
                                            break;
                                        default:
                                            break;
                                    }

                                    // 7.3 After every three columns there is a new federal state.
                                    if (genderSwitchCounter == this.genderList.Count)
                                    {
                                        // Set and reset values.
                                        genderSwitchCounter = 0;
                                        this.population.Year = tempSaveDateTime;

                                        // Add the population into correct federal state.
                                        this.federalStateList[federalStateCounter].PopulationLevel.Add(population);

                                        // Increase federal state counter.
                                        federalStateCounter++;
                                        this.population = new Population();
                                    }

                                }

                                // Change next column.
                                genderSwitchCounter++;
                            }
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Read the incoming csv file as single Lines.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Csv Content</returns>
        private List<string> ReadCsv(string path)
        {
            List<string> result = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.GetEncoding("Windows-1252")))
                {
                    while (!sr.EndOfStream)
                    {
                        result.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception)
            {
                // result = ex.Message;
                result = null;
            }

            return result;
        }
 
        /// <summary>
        /// Get the federal state collection.
        /// </summary>
        /// <returns>Federal State Collection</returns>
        public List<FederalState> GetFederalSateCollection () 
        { 
            return this.federalStateList; 
        }

        /// <summary>
        /// Get the population date collection.
        /// </summary>
        /// <returns>Population Date Collection</returns>
        public List<DateTime> GetPopulationDateCollection ()
        {
            return this.populationDateList;
        }
    }
}