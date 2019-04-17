using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise
{
    class Program
    {
        static void Main(string[] args)
        {
        modulus:

            Console.WriteLine(100 % 8);

        BIDMAS:

            Console.WriteLine("eneter digit");

           
            string sdigit = Console.ReadLine();

            double digit = Convert.ToInt32(sdigit);

            double result = (Math.Pow(digit, 2) +101)/ 10 - 4;

            Console.WriteLine(result);

            //Write a method which takes a double as an input, squares it, adds 101, 
            //divides by 10 then subtracts 4.  Return a double rounded to 3 decimal places.
        }
    }
}
