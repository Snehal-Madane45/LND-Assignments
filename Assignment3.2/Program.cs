using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Stack<int> stack = new Stack<int>(); 
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);           
            stack.Push(4);

            foreach (int i in stack)
            {
                Console.WriteLine("Push Element in Array:"+i+",");
            }
            stack.Pop();
            stack.Pop();
            foreach (int i in stack)
            {
                Console.WriteLine("After Pop ,Element in Array:" + i + ",");
            }

        }
    }
}
