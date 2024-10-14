public class Book
{
    // Properties - These define the characteristics of a Book object
    public string Title { get; set; }
    public string AuthorFirstName { get; set; }
    public string AuthorLastName { get; set; }
    public int PageCount { get; set; }
    public string Publisher { get; set; }
    public DateTime RegistrationDate { get; set; }

    public Book() // Default Constructor - This is called when an object is created with no parameters
    {
        RegistrationDate = DateTime.Now; // Automatically sets the registration date to the current time
        Console.WriteLine("Book object created!");
    }

    // Parameterized Constructor - This constructor assigns values during object creation
    public Book(string title, string authorFirstName, string authorLastName, int pageCount, string publisher)
    {
        // Assigning the parameter values to the properties
        Title = title;
        AuthorFirstName = authorFirstName;
        AuthorLastName = authorLastName;
        PageCount = pageCount;
        Publisher = publisher;
        RegistrationDate = DateTime.Now;
    }
    public void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {AuthorFirstName} {AuthorLastName}, Pages: {PageCount}, Publisher: {Publisher}, Registration Date: {RegistrationDate}");
    }
}
