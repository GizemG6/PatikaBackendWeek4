public class Program
{
    static void Main(string[] args)
    {
        // create an instance of software developer
        SoftwareDeveloper softwareDeveloper = new SoftwareDeveloper();
        softwareDeveloper.firstName = "Gizem";
        softwareDeveloper.lastName = "Günes";
        softwareDeveloper.position = "Software Developer";
        softwareDeveloper.JobPosition();

        // create an instance of project manager
        ProjectManager projectManager = new ProjectManager();
        projectManager.firstName = "Hasan";
        projectManager.lastName = "Cildirmis";
        projectManager.position = "Project Manager";
        projectManager.JobPosition();

        // create an instance of sales representative
        SalesRepresentative salesRepresentative = new SalesRepresentative();
        salesRepresentative.firstName = "Ali";
        salesRepresentative.lastName = "Yilmaz";
        salesRepresentative.position = "Sales Representative";
        salesRepresentative.JobPosition();
    }
}

public abstract class BaseEmployee  // abstract class representing a general employee
{
    // properties for all employees
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string position { get; set; }

    public abstract void JobPosition();  // abstract method for the employee's task
}

public class SoftwareDeveloper : BaseEmployee // derived class software developer
{
    public override void JobPosition()
    {
        Console.WriteLine($"{firstName} {lastName} is working as a software developer."); // implementation JobPosition for software developer
    }
}

public class ProjectManager : BaseEmployee // derived class project manager
{
    public override void JobPosition()
    {
        Console.WriteLine($"{firstName} {lastName} is working as a project manager."); // implementation JobPosition for project manager
    }
}

public class SalesRepresentative : BaseEmployee // derived class sales representative
{
    public override void JobPosition()
    {
        Console.WriteLine($"{firstName} {lastName} is working as a sales representative."); // implementation JobPosition for sales representative
    }
}
