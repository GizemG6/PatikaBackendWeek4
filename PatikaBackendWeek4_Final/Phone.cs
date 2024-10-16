using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaBackendWeek4_Final
{
    public class Phone : BaseMachine
    {
        public bool trLicense { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            if (trLicense)
            {
                Console.WriteLine("Product has an TR license");
            }
            else
            {
                Console.WriteLine("Product has not an TR license");
            }
        }

        public override void GetProductName()
        {
            Console.WriteLine($"Your phone name is {Name}");
        }
    }
}
