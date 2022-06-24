using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsLND
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculators calculator = new Calculators();
            Console.WriteLine("Enter Calculator choices:\n1: Addition\n2:Substraction\n3:Multification\n4:Division");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter First Number");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int y = int.Parse(Console.ReadLine());
                    int result = calculator.Addition(x, y);
                    Console.WriteLine("Addition is :" + result);
                    break;
                case 2:
                    Console.WriteLine("Enter First Number");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int b = int.Parse(Console.ReadLine());
                    int result1 = calculator.Substraction(a, b);
                    Console.WriteLine("Substraction is :" + result1);
                    break;
                case 3:
                    Console.WriteLine("Enter First Number");
                    int x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int y1 = int.Parse(Console.ReadLine());
                    int result2 = calculator.Multiplication(x1, y1);
                    Console.WriteLine("Multiplication is :" + result2);
                    break;
                case 4:
                    Console.WriteLine("Enter First Number");
                    int x2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int y2 = int.Parse(Console.ReadLine());
                    int result3 = calculator.Division(x2, y2);
                    Console.WriteLine("Divison is :" + result3);
                    break;
            }
        }

    }
}

