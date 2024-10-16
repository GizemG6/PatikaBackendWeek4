using System.Numerics;

namespace PatikaBackendWeek4_Final
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool _continue = true; // continue flag

            while (_continue)
            {
                Console.WriteLine("Press 1 to produce phone, press 2 to produce a computer");
                string choice = Console.ReadLine();

                if (choice == "1") // handle the choice
                {
                    Phone phone = new Phone(); // create a new phone object

                    Console.WriteLine("Please enter phone information:");

                    Console.WriteLine("Phone Name:");
                    phone.Name = Console.ReadLine();

                    Console.WriteLine("Phone Serial Number:");
                    phone.serialNumber = Console.ReadLine();

                    Console.WriteLine("Description:");
                    phone.Description = Console.ReadLine();

                    Console.WriteLine("Operating System:");
                    phone.operatingSystem = Console.ReadLine();

                    Console.WriteLine("Is there a TR license?(Please enter true if yes, otherwise false)");
                    string trLicence = Console.ReadLine();
                    phone.trLicense = trLicence == "true";

                    phone.PrintInfo();

                    Console.WriteLine("The phone was successfully produced");
                }
                else if (choice == "2")
                {
                    Computer computer = new Computer(); // create a new computer object

                    Console.WriteLine("Please enter computer information:");

                    Console.WriteLine("Computer Name:");
                    computer.Name = Console.ReadLine();

                    Console.WriteLine("Computer Serial Number:");
                    computer.serialNumber = Console.ReadLine();

                    Console.WriteLine("Description:");
                    computer.Description = Console.ReadLine();

                    Console.WriteLine("Operating System:");
                    computer.operatingSystem = Console.ReadLine();

                    Console.WriteLine("USB count:");
                    string usbCount = Console.ReadLine();
                    computer.USBPortCount = int.Parse(usbCount);

                    Console.WriteLine("Is there Bluetooth?(Please enter true if yes, otherwise false)");
                    string bluetooth = Console.ReadLine();
                    computer.Bluetooth = bluetooth == "yes";

                    computer.PrintInfo();
                    Console.WriteLine("The computer was successfully produced");
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please press either 1 or 2."); // error message for invalid selection
                    continue; // continue to the next iteration
                }

                Console.WriteLine("Would you like to produce another product? (Yes/No):"); // ask if the user wants to create another product
                string result = Console.ReadLine().ToLower();
                if (result == "Yes") // if user wants to continue
                {
                    _continue = false;
                    Console.WriteLine("Have a nice day!");
                }
            }

        }
    }
}
