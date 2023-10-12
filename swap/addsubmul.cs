using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class addsubmul
    {
        static void Main(string[] args)
        {
           int num1, num2;
           Console.WriteLine("input the first number: ");
             num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the second number: ");
             num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            //Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
        }
    }
}
