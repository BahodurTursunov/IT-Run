using System.Drawing;

namespace HW2
{
    abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? Position { get; set; }
        public double Salary { get; set; }

        //public Employee(int employeeId, string employeeName, string position, double salary)
        //{
        //    EmployeeId = employeeId;
        //    EmployeeName = employeeName;
        //    Position = position;
        //    Salary = salary;
        //}

        // abstract void CurrentPosition(Employee employee);
    }

    class Manager : Employee
    {
        public Manager(Employee employee)
        {
            //EmployeeId = 1;
            //EmployeeName = "Azim";
            //Position = "Maneger";
            //Salary = 20000;
            Console.WriteLine($"ID: {EmployeeId}, EmployeeName: {EmployeeName}, Position: {Position}, Salary: {Salary}");
        }
    }

    class Supervisor : Employee
    {
        public Supervisor(Employee employee)
        {
            Console.WriteLine($"ID: {EmployeeId}, EmployeeName: {EmployeeName}, Position: {Position}, Salary: {Salary}");
        }
    }

    class Technician : Employee
    {
        public Technician(Employee employee)
        {
            Console.WriteLine($"ID: {EmployeeId}, EmployeeName: {EmployeeName}, Position: {Position}, Salary: {Salary}");
        }
    }
}
