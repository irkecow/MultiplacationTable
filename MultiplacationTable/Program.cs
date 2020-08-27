using System;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.InteropServices.ComTypes;

namespace MultiplacationTable
{
    class Program
    {
        static void WriteBar(int legnth)
        {
            string line = "+";
        
            for (int i = 0; i < legnth * 5 - 1; i++) {
                line = line + "-";
            }

            line = line + "+";

            Console.WriteLine(line);
            
        }
        static void Main()
        {
            string row = "";

            Console.WriteLine("What number should the table go up to?\n");
            string maxNumberString = Console.ReadLine();

            int maxNumber = Int32.Parse(maxNumberString);

            int LineLegnth = maxNumber;

            Console.WriteLine("\n\n");

            WriteBar(LineLegnth);

            maxNumber = maxNumber + 1;

            for (int i = 1; i < maxNumber; i++)
            {
                for(int j = 1; j < maxNumber; j++)
                {
                    if (i * j < 10) { row = row + "|   " + (i * j); }
                    else if (i * j < 100) { row = row + "|  " + (i * j); }
                    else if (i * j < 1000) { row = row + "| " + (i * j); }
                    else { row = row + "| " + (i * j); }
                }

                row = row + "|";
                Console.WriteLine(row);
              
                row = "";
            }
            WriteBar(LineLegnth);
        }
    }
}
