using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(check(4, 5, 7));
            Console.WriteLine(check(7,4,12));
            Console.WriteLine(check(10,10,12));
            Console.WriteLine(check(12,12,18));
            Console.ReadKey();
        }
        public static int check(int x, int y, int z)
        {
            if (x ==y && y ==z) return  0;
            if (x == y) return z;
            if (x == z) return y;
            if (y == z) return x;
            return x+y+z;
        }
    }
}
