using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gibbs_Assignment10
{
    public class International : Flight
    {
        public International(int c, DateTime d, string dest, bool f) : base(c, d, dest, f)
        {
     
        }
        public override string GetDisplayText()
        {
            string required = "No";
            string output = "";

            if (FoodOrPassport == true)
                required = "Yes";
            output += base.GetDisplayText() + "--" + "International--" + "Passport Required: " + required;

            return output;
        }
    }
    
}
