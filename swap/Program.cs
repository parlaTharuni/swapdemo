using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num1, num2, temp;
            Console.WriteLine("input the first number:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input the second number:");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("after swapping:");
            Console.WriteLine("first number:"+num1);
            Console.WriteLine("secondnumber:" +num2);
            //swaping

         
}
}
}
