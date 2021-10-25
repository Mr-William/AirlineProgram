using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gibbs_Assignment10
{
    public partial class SelectFlight : Form
    {
        Flight f;
        Airline a;

        int[] codeArr = null;
        public SelectFlight(Airline tmp)
        {

            InitializeComponent();
            a = tmp;
            codeArr = new int[a.flightList.Count];
            
            for(int i = 0; i < tmp.flightList.Count; ++i)
            {
                cboFlights.Items.Add(tmp.flightList[i].Code.ToString() + tmp.flightList[i].Destination + tmp.flightList[i].Departure.ToString());
                if(tmp[i].GetType() == typeof(Domestic))
                {
                    f = (Domestic)tmp[i];
                }
                if (tmp[i].GetType() == typeof(International))
                {
                    f = (International)tmp[i];
                }
                codeArr[i] = tmp.flightList[i].Code;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(cboFlights.SelectedIndex > -1)
            {
                int j = cboFlights.SelectedIndex;

                Tag = codeArr[j];
                Close();
            }
            else
            {
                MessageBox.Show("You must select a flight.", "Error");
                cboFlights.Focus();
            }
        }

        private void SelectFlight_Load(object sender, EventArgs e)
        {

        }
    }
}
