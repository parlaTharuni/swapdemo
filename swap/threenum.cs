using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class threenum
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter first number -");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number - ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number - ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n", num1, num2, num3, ((num1 + num2) * num3), (num1 * num2 + num2 * num3));
        }
    }
}
    

