using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class absolute
    {
        static void Main(string[] args)
        {
            Console.WriteLine(result(13,40));
            Console.WriteLine(result(50,21));

        }
        public static int result(int a, int b)
        {
            if (a > b)
            {
                return (a - b) * 2;

            }
            return b - a;

        }
    }
}
