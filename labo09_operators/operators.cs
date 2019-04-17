using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo09_operators
{
    class operators
    {
        static void Main(string[] args)
        {
            int x = 100,
                y = x++;

            //output: x = 101 and 100
            Console.WriteLine($"x is {x} and y is {y}");

            int a = 100,
                b = ++a;
            //output: x = 101 and 101
            Console.WriteLine($"a is {a} and b is {b}");

        }
    }
}
