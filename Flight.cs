using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gibbs_Assignment10
{
    public abstract class Flight
    {
        public List<string> passengers;
        public Flight() { }

        public Flight(int c, DateTime d, string dest, bool fp)
        {
            Code = c;
            Departure = d;
            Destination = dest;
            FoodOrPassport = fp;
            passengers = new List<string>();

        }
        public int Code { get; set; }
        public DateTime Departure { get; set; }
        public string Destination { get; set; }
        public bool FoodOrPassport { get; set; }
        public virtual string GetDisplayText() => Code + "--" + Destination + "--" + Departure;
        public void AddPassenger(string n)
        {
            passengers.Add(n);
        }
        public string this[int i]
        {

            get
            {
                if (i < 0 || i >= passengers.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return passengers[i];
            }
        }
        public List<string> Passengers { get; set; }
    }
}
