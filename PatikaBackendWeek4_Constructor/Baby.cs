public class Baby
{
     public DateTime birthDate {  get; set; }
     public string firstName { get; set; }
     public string lastName  { get; set; }
     public Baby()
     {
         birthDate = DateTime.Now;
         Console.WriteLine("Ingaaaa");
     }
     public Baby(string firstName, string lastName)
     {
         this.firstName = firstName;
         this.lastName = lastName;
         birthDate = DateTime.Now;
         Console.WriteLine("Ingaaaa");
     }
}

