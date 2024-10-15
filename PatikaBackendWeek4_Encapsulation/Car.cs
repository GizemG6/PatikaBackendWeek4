public class Car
{
    // Properties
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    private int doorCount; // Backing field for DoorCount

    public int DoorCount // Property with encapsulation for DoorCount
    {
        get { return doorCount; }
        set
        { 
            if (value == 2 || value == 4) // Check if the value is either 2 or 4
                doorCount = value;
            else
            {
                Console.WriteLine("Warning: Door count can only be 2 or 4.");
                doorCount = -1; // Invalid value, set door count to -1
            }
        }
    }
    public Car(string brand, string model, string color, int doorCount) // Constructor to initialize a car object
    {
        Brand = brand;
        Model = model;
        Color = color;
        DoorCount = doorCount;  // Using the property for validation
    }
    
    public void DisplayCarInfo() // Method to display car details
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Color: {Color}, Door Count: {DoorCount}");
    }
}
