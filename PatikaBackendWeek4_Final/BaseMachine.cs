using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaBackendWeek4_Final
{
    public abstract class BaseMachine
    {

        // properties
        public DateTime productionDate { get; private set; }
        public string serialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string operatingSystem { get; set; }

        public BaseMachine()
        {
            productionDate = DateTime.Now; // production date is automatically set
        }

        public virtual void PrintInfo() // method to print information
        {
            Console.WriteLine($"Production Date: {productionDate}, Serial Number: {serialNumber}, Name: {Name}, Description: {Description}, " +
                $"Operating System: {operatingSystem}");
        }

        public abstract void GetProductName(); // abstract method to get product name

    }
}
