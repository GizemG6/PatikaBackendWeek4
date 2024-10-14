public class Person
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    // Method to display information
    public void DisplayInfo()
    {
        Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Date of Birth: {DateOfBirth.ToShortDateString()}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Student objects
        Person student1 = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            DateOfBirth = new DateTime(2005, 3, 15)
        };

        Person student2 = new Person
        {
            FirstName = "Emily",
            LastName = "Smith",
            DateOfBirth = new DateTime(2006, 7, 23)
        };

        // Teacher objects
        Person teacher1 = new Person
        {
            FirstName = "Sarah",
            LastName = "Johnson",
            DateOfBirth = new DateTime(1985, 1, 10)
        };

        Person teacher2 = new Person
        {
            FirstName = "Michael",
            LastName = "Brown",
            DateOfBirth = new DateTime(1978, 12, 5)
        };

        // Displaying information
        student1.DisplayInfo();
        student2.DisplayInfo();
        teacher1.DisplayInfo();
        teacher2.DisplayInfo();
    }
}