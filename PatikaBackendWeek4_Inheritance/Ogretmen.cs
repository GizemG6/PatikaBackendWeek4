public class Ogretmen : BaseKisi
{
    public int Salary {  get; set; }

    public void TeacherInfo()
    {
        Console.WriteLine($"Teacher Salary: {Salary}");
        BaseKisiInfo();
    }
}
