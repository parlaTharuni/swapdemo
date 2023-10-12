using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class min_max
    {
        static void Main(string[] args)
        {
            int a; int b;
            int max; int min;
            Console.WriteLine("enter first number:");
                a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                max = a;
            else
                max = b;
            if (a < b)
                min = a;
            else
                min = b;
            Console.WriteLine("Maximum number={0}",max);
            Console.WriteLine("Minimum number{0} ",min) ;
            Console.ReadKey();
        }
        }
    }


    

