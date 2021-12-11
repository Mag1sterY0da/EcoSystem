using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    public class LabHandler2 : Handler
    {
        private string ans { get; set; } = "";
        public Boolean isBusy { get; set; } = false;
        public override string HandleRequest(int condition)
        {
            if (condition == 2)
            {
                if (isBusy)
                {
                    Console.WriteLine("This Lab1 is busy. Sending request for next");
                    //Sending request for next Lab
                    ans = "Busy";
                }
                else
                {
                    Console.WriteLine("Recordings will be send immediately");
                    //Sending Recs
                    ans =  "Send";
                }
            }
            else if (Successor != null)
            {
                ans = Successor.HandleRequest(condition);
            }
            return ans;
        }
    }
}
