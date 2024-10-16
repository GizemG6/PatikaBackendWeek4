using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaBackendWeek4_Final
{
    public abstract class BaseMachine
    {
        public DateTime productionDate { get; private set; }
        public string serialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string operatingSystem { get; set; }

        public BaseMachine()
        {
            productionDate = DateTime.Now;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Production Date: {productionDate}, Serial Number: {serialNumber}, Name: {Name}, Description: {Description}, " +
                $"Operating System: {operatingSystem}");
        }

        public abstract void GetProductName();

    }
}
