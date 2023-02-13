using System;
namespace EmployeeDetails
{
    class Employee
    {
        string employeeId;
        public string EmployeeId
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        string department;
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public static void PrintEmployeeDetails(Employee employee)
        {
            Console.WriteLine("Employee ID: " + employee.EmployeeId);
            Console.WriteLine("Name: " + employee.Name);
            Console.WriteLine("Salary: " + employee.Salary);
            Console.WriteLine("Department: " + employee.Department);
        }
    }
}
