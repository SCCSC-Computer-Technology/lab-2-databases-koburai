using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace A_Waddell_CPT_206_A80S_Lab_2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void citiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.citiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.cityDBDataSet.Cities);
        }

        private void btnSortAscName_Click(object sender, EventArgs e)
        {
            this.citiesTableAdapter.SortByCityName(this.cityDBDataSet.Cities); // sort by cities NAME ascending bc how else do you sort names            }
        }

        private void btnPopDescSort_Click(object sender, EventArgs e)
        {
            this.citiesTableAdapter.SortByCityPopDesc(this.cityDBDataSet.Cities); // sort by pop ASCENDING
        }

        private void btnPopAscSort_Click(object sender, EventArgs e)
        {
            this.citiesTableAdapter.SortByCityPopAsc(this.cityDBDataSet.Cities); // sort by pop DESCENDING
        }

        private void btnGetAvg_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            int count = 0;

            foreach (DataGridViewRow row in citiesDataGridView.Rows) // cycle through EVERY ROW
            {
                sum += Convert.ToDecimal(row.Cells["Population"].Value); // accumulate
                count++; // increase counter
            }

            if (count > 0) // if code actually triggers (count will always be above 0 bc ++)
            {
                count = count - 1; // for some reason it counts the last null line?? so we gotta subtract that
                decimal average = sum / count;
                lblGet.Text = average.ToString("F2");
            }
            else
            {
                MessageBox.Show("An error occured. Whoops.");
                return;
            }

        }

        private void btnGetTotal_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (DataGridViewRow row in citiesDataGridView.Rows) // cycle through EVERY ROW
            {
                sum += Convert.ToInt32(row.Cells["Population"].Value); // accumulate. was initially gonna be ToInt16 but then i realized we might need more than 32767
            }
            lblGet.Text = sum.ToString("F2"); // round to 2 decimal place.
        }

        private void btnGetHighest_Click(object sender, EventArgs e)
        {
            int maxPop = 0; // declare 
            foreach (DataGridViewRow row in citiesDataGridView.Rows) // LOOP
            {
                int population = Convert.ToInt32(row.Cells["Population"].Value); // get ints of all pop column
                if (population > maxPop) // if its bigger
                {
                    maxPop = population; // congrats youvbe been promoted
                }
            }
            lblGet.Text = "The highest population is: " + maxPop.ToString(); // update display
        }

        private void btnGetLowest_Click(object sender, EventArgs e)
        {
            int minPop = 0; // declare 
            foreach (DataGridViewRow row in citiesDataGridView.Rows) // LOOP
                if (row.Cells["Population"].Value != DBNull.Value) // this is because the last line is always null and it BREAKS THINGS.
                {
                    {
                        int population = Convert.ToInt32(row.Cells["Population"].Value); // get ints of all pop column
                        if (population < minPop) // if its smaller
                        {
                            minPop = population; // congrats youvbe been promoted
                        }
                    }
                }
            lblGet.Text = "The lowest population is: " + minPop.ToString(); // update display
        }
    }
}
