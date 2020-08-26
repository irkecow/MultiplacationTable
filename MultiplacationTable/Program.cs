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

                   row = row + "|" + (i * j);
                }
                
                Console.WriteLine(row,"\n");
                row = "";
            }
        }
    }
}
