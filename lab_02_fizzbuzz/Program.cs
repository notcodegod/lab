using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }


                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
            }

        }
    }
}
