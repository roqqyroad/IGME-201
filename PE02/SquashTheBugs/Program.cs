
using System;

namespace SquashTheBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare string to hold all numbers
            string allNumbers = null;

            // declare int counter
            // OLD LINE: 
            // int i = 0
            // NEW LINE: Within the for loop  

            // loop through the numbers 1 through 10
            // OLD LINE: 
            // for (int i = 0; i < 10; ++i)
            // NEW LINE: Changes - combined with the int i line, code goes thru loop and grabs 10 now, changed ++i to i++,
            // made it not include 1 because itd give divide by zero angryness
            for (int i = 2; i < 11; i++)
            {
                // declare string to hold all numbers
                // OLD LINE: 
                // string allNumbers = null;
                // NEW LINE: Moved up further in code to instance before loop and so bottom WriteLine can actually read it

                // output explanation of calculation
                Console.Write(i + "/" + (i - 1) + " = "); //..?

                // output the calculation based on the numbers
                Console.WriteLine(i / (i - 1));

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // OLD LINE:
                // i = i + 1;
                // REMOVED: not needed I think?
            }

            // output all numbers which have been processed
            // OLD LINE:
            // Console.WriteLine("These numbers have been processed: " allNumbers);
            // NEW LINE: added +                                    v here
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}

