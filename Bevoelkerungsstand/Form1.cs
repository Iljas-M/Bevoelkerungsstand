using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bevoelkerungsstand
{
    public partial class Bevoelkerungstand : System.Windows.Forms.Form
    {
        /// <summary>
        /// The record query ref.
        /// </summary>
        private RecordQuery query;

        /// <summary>
        /// The selected federal state.
        /// </summary>
        private string selectedFederalState;

        /// <summary>
        /// The selected population date.
        /// </summary>
        private string selectedPopulationDate;

        /// <summary>
        /// The Bevoelkerungstand.
        /// </summary>
        public Bevoelkerungstand()
        {
            InitializeComponent();

            // 0. Init.
            this.query = new RecordQuery();
        }

        /// <summary>
        /// The Form Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            // 1, Fill the Federal State Data for cmb.
            foreach (var federalState in this.query.federalStateList)
            {
                FederalStates_cmb.Items.Add(federalState.Name);
            }


            // 2. Fill the Population Date Data on cmb.
            foreach (var populationDate in this.query.populationDateList)
            {
                Years_cmb.Items.Add(populationDate);
            }

            // 3. Default values.
            if (this.query.federalStateList.Count > 0 )
            {
                this.FederalStates_cmb.SelectedIndex = 0;
                this.Years_cmb.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No data could be found. Check if the 'CSV file' is closed as Excel.", "Warning");
            }
        }

        /// <summary>
        /// The FederalStates_cmb_SelectedIndexChanged.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FederalStates_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 4.1 Spread selected filter criteria and show result,
            UpdateChanges();
        }

        /// <summary>
        /// Years_cmb_SelectedIndexChanged,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Years_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 4.2 Spread selected filter criteria and show result,
            UpdateChanges();
        }

        /// <summary>
        /// Update Changes,
        /// </summary>
        private void UpdateChanges()
        {
            // First fill the selected Values.
            this.selectedFederalState = FederalStates_cmb.SelectedItem?.ToString();
            this.selectedPopulationDate = Years_cmb.SelectedItem?.ToString();

            // Then Filter the Values.
            if (selectedFederalState != null && selectedPopulationDate != null)
            {
                string result = this.query.YearStateFilter(selectedFederalState, DateTime.Parse(selectedPopulationDate));

                // Split and fill.
                string[] maleFamleTotalAmounts = result.Split(';');

                maleNumber_lb.Text = maleFamleTotalAmounts[0];
                femaleNumber_lb.Text = maleFamleTotalAmounts[1];
                totalNumber_lb.Text =  maleFamleTotalAmounts[2];
            }
        }
    }
}
