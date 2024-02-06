namespace Fabric.Models
{
    public class Department : BaseEntity
    {
        public string NameOfDepartment { get; set; }
        public int WorkersInDepartment { get; set; }

        public Department(string nameOfDepartment, int workersInDepartment)
        {
            NameOfDepartment = nameOfDepartment;
            WorkersInDepartment = workersInDepartment;

            Console.WriteLine($"Department Name: {nameOfDepartment}, Workers in Department: {workersInDepartment}");
        }

    }
}
