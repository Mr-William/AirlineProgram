using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gibbs_Assignment10
{
    public class Domestic : Flight
    {
        public Domestic(int c, DateTime d, string n, bool f) : base(c, d, n, f)
        {
     
        }
        public override string GetDisplayText()
        {
            string provided = "No";
            string output = "";

            if (FoodOrPassport == true)
                provided = "Yes";
            output += base.GetDisplayText() + "--" + "Domestic--" + "Food Provided: " + provided;

            return output;
        }


    }

}
