public class Ogrenci : BaseKisi
{
    public int studentNumber {  get; set; }

    public void StudentInfo()
    {
        Console.WriteLine($"Student Number: {studentNumber}");
        BaseKisiInfo();
    }
}
