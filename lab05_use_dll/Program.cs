using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using lab04_dll;

namespace lab05_use_dll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading from another Library");
            var item = new AdeolaLibrary();
            item.AdesData = "SOME DATA HERE";
            Console.WriteLine(item.AdesData);
            Console.WriteLine(item.adesFixedData);

        }
    }
}
