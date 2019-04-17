using System;


namespace Lab_01_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First applicsation");

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("hit any key to exit");

            foreach(string item in args)
            {
                Console.WriteLine("your item is - " + item); 
            }

            Console.ReadLine();


            
        }
    }
}
