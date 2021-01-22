using System;
using System.Collections.Generic;
using System.Linq;
namespace FindStrName_Position_size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Cars = {"Benz Maybach", "Lambo Ghost",
                "RollsRoyce", "Bugatti", "BMW super",
                "Audi", "Bentley", "Ferarri", "Tesla GT" };
            Console.WriteLine("# ENTER NAME OF CAR TO SEARCH: ");
            string checkit = Console.ReadLine();
            int Index = Array.FindIndex(Cars, m => m == checkit);
            int SeeLength = Cars.Length;
            if ( Cars.Contains(checkit))
            {
                Console.Write(" ( "+checkit);
                Console.Write(" , "+ Index);
                Console.Write(" , " + SeeLength + " )");
                Console.WriteLine("\n\n");
                Console.WriteLine("\t DETAILS");
                Console.WriteLine("======================");
                Console.Write("# NAME OF CAR : " + checkit);
                Console.WriteLine();
                Console.Write("# POSITION IN ARRAY : " + Index);
                Console.WriteLine();
                Console.Write("# SIZE OF ARRAY : " + SeeLength);

            }
            else
            {
                Console.WriteLine("Your inputs Don't Match Strings in the Array");
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("\n\n");
        }
    }

}

