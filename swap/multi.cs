using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class multi
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("input the first number to multiply");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the second number to multiply");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the third number to multiply");
            num3 = Convert.ToInt32(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine("{0}x{1}x{2}={3}", num1, num2, num3, result);
        }
    }
}
