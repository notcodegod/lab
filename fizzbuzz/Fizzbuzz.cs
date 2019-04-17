using System;

public class Class1
{
	public Class1()
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
