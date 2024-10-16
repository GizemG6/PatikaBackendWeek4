public class Ogretmen : BaseKisi
{
    public decimal Salary {  get; set; }

    public void TeacherInfo()
    {
        Console.WriteLine($"Teacher Salary: {Salary}");
        BaseKisiInfo();
    }
}
