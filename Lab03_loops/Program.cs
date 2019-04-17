using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // the 4 types of loops


            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("number: " + i);


            //}
            int x=200;
            //while (x < 100)
            //    {
            //     x++;
            //}

            do
            {


                Console.WriteLine("number: " + x);
                x++;
            }
            while (x < 100);

            int[] iarray = new int[] { 0, 2, 3, 4, 5 };

            foreach (int elements in iarray)
            {
                Console.WriteLine(elements);
            }

            System.Threading.Thread.Sleep(2000);
            //Console.ReadLine();

            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            int counter = 0;
            //while (counter < 1000)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}
            int[] array1 = new int[1000];
            for (int i =1; i<array1.Length; i++)
            {
                array1[i] = i+1;
                Console.WriteLine(i);
            }

        }
    }
}
