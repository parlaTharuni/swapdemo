using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class triple
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumTriple(2, 2));
            Console.WriteLine(SumTriple(2, 3));

        }
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;

        }

    }
}
