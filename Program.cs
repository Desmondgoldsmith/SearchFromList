using System;
using System.Collections.Generic;
using System.Linq;
namespace FindStrName_Position_size
{
    class Program
    {
        static void Main(string[] args)
        {
           //creating the array and initializing it to names of cars
            string[] Cars = {"Benz Maybach", "Lambo Ghost",
                "RollsRoyce", "Bugatti", "BMW super",
                "Audi", "Bentley", "Ferarri", "Tesla GT" };
            //receiving input from user
            Console.WriteLine("# ENTER NAME OF CAR TO SEARCH: ");
            string checkit = Console.ReadLine();
            //getting index of user's input if the user's input is foud in the array
            int Index = Array.FindIndex(Cars, m => m == checkit);
           //getting size of array
            int SeeLength = Cars.Length;
            //comparing users inputs to the indexes of the array
            //if user's input matches a value in the array, do this :
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
            //else do that :
            else
            {
                Console.WriteLine("Your inputs Don't Match Strings in the Array");
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("\n\n");
        }
    }
    //end
}

