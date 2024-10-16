public class BaseKisi // base class
{
    public string firstName { get; set; }
    public string lastName { get; set; }

    public void BaseKisiInfo() // info
    {
        Console.WriteLine($"Name: {firstName}, Last Name: {lastName}");
    }
}
