using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gibbs_Assignment10
{
    public class Airline
    {
        private string name;
        public List<Flight> flightList;
        public Airline() { }
        public Airline(string n)
        {
            Name = n;
            flightList = new List<Flight>();
            LatestCode = 0;
        }
        public string Name { get; set; }
        public List<Flight> FlightList { get; set; }
        public static int LatestCode { get; set; }
        public void AddFlight(Flight f)
        {
            LatestCode += 55;
            f.Code = LatestCode;
            flightList.Add(f);
        }
        public void AddDomesticFlight(DateTime dep, string dest, bool p)
        {
            LatestCode += 55;
            Domestic f = new Domestic(LatestCode, dep, dest, p);
            flightList.Add(f);
        }
        public void AddInternationalFlight(DateTime dep, string dest, bool p)
        {
            LatestCode += 55;
            International f = new International(LatestCode, dep, dest, p);
            flightList.Add(f);
        }
        public void RemoveFlight(Flight f)
        {
            flightList.Remove(f);
        }
        public Flight this[int i]
        {
            get
            {
                if (i < 0 || i >= flightList.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return flightList[i];
            }
        }
        public Flight this[string dest]
        {
            get
            {
                foreach(Flight f in flightList)
                {
                    if(f.Destination == dest)
                    {
                        return f;
                    }
                }
                return null;
            }
        }
    }
}
