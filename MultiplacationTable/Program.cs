using System;
using System.Collections.Specialized;
using System.Data;

namespace MultiplacationTable
{
    class Program
    {
        static void Main()
        {
            string row = "";

            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                   if (i * j < 10) { row = row + "| " + (i * j); }
                   else { row = row + "|" + (i * j); }                  
                }

                row = row + "|";
                Console.WriteLine(row);
              
                row = "";
            }
        }
    }
}
