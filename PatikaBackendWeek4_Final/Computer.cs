using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaBackendWeek4_Final
{
    public class Computer : BaseMachine
    {
        public bool Bluetooth { get; set; }

        private int _usbPortCount;

        public int USBPortCount
        {
            get
            {
                return _usbPortCount;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbPortCount = value;
                }
                else
                {
                    Console.WriteLine("Warning: Invalid USB port count!");
                    _usbPortCount = -1;
                }
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            if (Bluetooth)
            {
                Console.WriteLine("Product has Bluetooth feature.");
            }
            else
            {
                Console.WriteLine("Product has not Bluetooth feature.");
            }
            Console.WriteLine($"USB count: {_usbPortCount}");
        }

        public override void GetProductName()
        {
            Console.WriteLine($"Your computer name is {Name}");
        }
    }
}
