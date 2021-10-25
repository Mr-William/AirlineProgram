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
    public partial class Form1 : Form
    {
        public Airline newAirline = new Airline("New Air");
        public Form1()
        {
            InitializeComponent();

            newAirline.AddDomesticFlight(DateTime.Now.AddDays(30), "Las Vegas, NV, USA", true);
            newAirline.AddDomesticFlight(DateTime.Now.AddDays(45), "Salt Lake City, UT, USA", true);
            newAirline.AddDomesticFlight(DateTime.Now.AddDays(15), "Chicago, IL, USA", false);
            newAirline.AddInternationalFlight(DateTime.Now.AddDays(120), "Rome, Italy", true);
            newAirline.AddInternationalFlight(DateTime.Now.AddDays(60), "London, England", true);
            newAirline.AddInternationalFlight(DateTime.Now.AddDays(50), "Mexico City, Mexico", false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            lblViewing.Text = "All Flights";
            clearLists();
            if (newAirline.flightList.Count > 0)
            {
                clearLists();
                string passOrMeal = "";
                foreach (Flight f in newAirline.flightList)
                {
                    if (f.FoodOrPassport == true)
                        passOrMeal = "Yes";
                    else
                        passOrMeal = "No";
                    lstFlightCode.Items.Add(f.Code.ToString());
                    lstDeparture.Items.Add(f.Departure.ToString());
                    lstDestinations.Items.Add(f.Destination);
                    if(f.GetType() == typeof(Domestic))
                    {
                        lstPassport.Items.Add("N/a");
                        lstMeals.Items.Add(passOrMeal);
                    }
                    if(f.GetType() == typeof(International))
                    {
                        lstPassport.Items.Add(passOrMeal);
                        lstMeals.Items.Add("N/a");
                    }
                }
            }
            else
                MessageBox.Show("There are no flights currently stored", "Notice");
        }

        private void btnInternationalFlights_Click(object sender, EventArgs e)
        {
            clearLists();
            lblViewing.Text = "All International Flights";
            string provided = "";

            if (newAirline.flightList.Count > 0)
            {
                for (int i = 0; i < newAirline.flightList.Count; ++i)
                {
                    if (newAirline.flightList[i].GetType() == typeof(International))
                    {
                        if (newAirline.flightList[i].FoodOrPassport == true)
                            provided = "Yes";
                        else
                            provided = "No";
                        lstFlightCode.Items.Add(newAirline.flightList[i].Code.ToString());
                        lstDeparture.Items.Add(newAirline.flightList[i].Departure.ToString());
                        lstDestinations.Items.Add(newAirline.flightList[i].Destination);
                        lstPassport.Items.Add(provided);
                        lstMeals.Items.Add("N/a");
                    }
                }
            }
            else
                MessageBox.Show("No international flights are currently available", "Notice");
        }

        private void btnDomestic_Click(object sender, EventArgs e)
        {
            clearLists();
            lblViewing.Text = "All Domestic Flights";
            string provided = "";
            if (newAirline.flightList.Count > 0)
            {
                for(int i = 0; i < newAirline.flightList.Count; ++i)
                {
                    if (newAirline.flightList[i].GetType() == typeof(Domestic))
                    {
                        if (newAirline.flightList[i].FoodOrPassport == true)
                            provided = "Yes";
                        else
                            provided = "No";
                        lstFlightCode.Items.Add(newAirline.flightList[i].Code.ToString());
                        lstDeparture.Items.Add(newAirline.flightList[i].Departure.ToString());
                        lstDestinations.Items.Add(newAirline.flightList[i].Destination);
                        lstPassport.Items.Add("N/a");
                        lstMeals.Items.Add(provided);
                    }
                }
            }
            else
                MessageBox.Show("No domestic flights are currently available", "Notice");
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {

            lblViewing.Text = "Make a Selection on the Left to begin....";
            lstFlightCode.Clear();
            Form newPassenger = new AddPassenger(newAirline.flightList);
            newPassenger.ShowDialog();
        }

        private void btnListPassengers_Click(object sender, EventArgs e)
        {
            Form flightSelect = new SelectFlight(newAirline);
            flightSelect.ShowDialog();
            lblViewing.Text = "Listing passengers and Flight info for Flight ID: " + flightSelect.Tag;
            int code;
            Flight f = null;
            int.TryParse(flightSelect.Tag.ToString(), out code);
            for(int i = 0; i < newAirline.flightList.Count; i++)
            {
                if(newAirline.flightList[i].GetType() == typeof(Domestic))
                    f = (Domestic)newAirline.flightList[i];
                if (newAirline.flightList[i].GetType() == typeof(International))
                    f = (International)newAirline.flightList[i];
                if (newAirline.flightList[i].Code == code)
                {
                    for(int j = 0; j < f.passengers.Count; ++j )
                    {
                        lstPassengers.Items.Add(f[j]);
                    }
                }
            }
        }
        private void clearLists()
        {
            lstFlightCode.Clear();
            lstDeparture.Clear();
            lstPassport.Clear();
            lstMeals.Clear();
            lstPassengers.Clear();
            lstDestinations.Clear();
        }
    }
}
