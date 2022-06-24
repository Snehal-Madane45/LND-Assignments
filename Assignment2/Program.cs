using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine("Enter Employee ID:");
            employee.EmpNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            employee.EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            employee.Salary = double.Parse(Console.ReadLine());
            double grosssalary = employee.CalculateGross();
            Console.WriteLine("Gross Salary of Employee:" + grosssalary);
            double netsalary = employee.CalculateSalary();
            Console.WriteLine("NetSalary of Employee:" + netsalary);
            employee.DisplayDetails();


        }
    }
}
