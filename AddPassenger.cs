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
    public partial class AddPassenger : Form
    {
        List<Flight> flights = new List<Flight>();
        public AddPassenger(List<Flight> fl)
        {
            InitializeComponent();
            flights = fl;
        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {
            if(rdoInternational.Checked == true)
            {
                for(int i = 0; i < flights.Count; ++i)
                {
                    if(flights[i].GetType() == typeof(International))
                        cboDestinations.Items.Add(flights[i].GetDisplayText());
                }
            }
            else if(rdoDomestic.Checked == true)
            {
                for (int i = 0; i < flights.Count; ++i)
                {
                    if (flights[i].GetType() == typeof(Domestic))
                        cboDestinations.Items.Add(flights[i].GetDisplayText());
                }
            }
        }

        private void rdoDomestic_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoDomestic.Checked == true)
            {
                cboDestinations.Items.Clear();

                for (int i = 0; i < flights.Count; ++i)
                {
                    if (flights[i].GetType() == typeof(Domestic))
                        cboDestinations.Items.Add(flights[i].GetDisplayText());
                }
            }

        }

        private void rdoInternational_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoInternational.Checked == true)
            {
                cboDestinations.Items.Clear();

                for (int i = 0; i < flights.Count; ++i)
                {
                    if (flights[i].GetType() == typeof(International))
                        cboDestinations.Items.Add(flights[i].GetDisplayText()) ;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtPassengerName.Text)))
            {
                if (cboDestinations.SelectedIndex > -1)
                {
                    string destination = cboDestinations.Text;

                    foreach (Flight f in flights)
                    {
                        if (f.Destination == destination)
                        {
                            if (rdoDomestic.Checked == true)
                            {
                                Domestic tmp = (Domestic)f;
                                tmp.AddPassenger(txtPassengerName.Text);
                            }
                            if (rdoInternational.Checked == true)
                            {
                                International tmp = (International)f;
                                tmp.AddPassenger(txtPassengerName.Text);
                            }
                        }
                    }

                    Close();
                }
                else
                {
                    MessageBox.Show("You must select a destination.", "Error");
                    cboDestinations.Focus();
                }
            }
            else
            {
                MessageBox.Show("Passenger name cannot be left blank.", "Error");
                txtPassengerName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
