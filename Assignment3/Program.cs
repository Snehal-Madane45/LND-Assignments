using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Manager manager = new Manager();
            MarketingExecutive marketingExecutive = new MarketingExecutive();
            Console.WriteLine("1: Manager\n2:Marketing Executive");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
            Console.WriteLine("Enetr Employee ID");
            manager.EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            manager.Name = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            manager.Salary = float.Parse(Console.ReadLine());
            manager.DisplayDetails();
                    break;
                    case 2:
                    Console.WriteLine("Enter Name");
                    marketingExecutive.Name= Console.ReadLine();
                    Console.WriteLine("Enter Salary");
                    marketingExecutive.Salary= float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Kilometers:");
                    marketingExecutive.Kilometer=float.Parse(Console.ReadLine());
                    marketingExecutive.DisplayDetails();
                    break;
        }
        }
    }
}
