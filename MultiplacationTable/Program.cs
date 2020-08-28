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
            string line = "+"; //put the "+" in front of the string
        
            for (int i = 0; i < legnth * 5 - 1; i++) { //b/c there 5 spaces for the numbers we add 5 "-" for each number then "remove" one.
                line = line + "-";//add the "-"s
            }

            line = line + "+"; //put the "+" at the end

            Console.WriteLine(line); //output the line
            
        }

        static int getNumber()
        {
            Console.WriteLine("What number should the table go up to?\n");
            string maxNumberString;

            while (true)
            {
                try
                {
                    maxNumberString = Console.ReadLine();
                    int maxNumber = Int32.Parse(maxNumberString);
                    if (maxNumber > 31) {
                        Console.WriteLine("Please Enter a Number under 31\n");
                    }
                    else { return (maxNumber); }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please Enter a Valid Number\n");
                    maxNumberString = "";
                }
            }
        }
        static void Main()
        {
            string row = ""; //a string to store each row b/c Console.WriteLine has a built in \n at the end

            int maxNumber = getNumber(); //call get number to get the user to input a valid number

            int LineLegnth = maxNumber; //set the legnth of the line
            maxNumber = maxNumber + 1; //add one to the max number because arrys start at 0 and we don't use 0 on this table

            Console.Clear(); //clear the console to remove the users input

            WriteBar(LineLegnth); //put the bar ontop of the table

            for (int i = 1; i < maxNumber; i++) //up
            {
                for(int j = 1; j < maxNumber; j++) //rows
                {
                    if (i * j < 10) { row = row + "|   " + (i * j); }
                    else if (i * j < 100) { row = row + "|  " + (i * j); }
                    else if (i * j < 1000) { row = row + "| " + (i * j); }
                    else { row = row + "| " + (i * j); } //a shitty hardcoded way to do spacing. breakes if the number entered is over 31
                }

                row = row + "|"; //put a line at the end of each row
                Console.WriteLine(row); //output the rows
              
                row = ""; //clear the rows
            }
            WriteBar(LineLegnth); //bottom bar.
        }
    }
}
