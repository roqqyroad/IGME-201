using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavColorNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //notes: an abstraction is a removal / process of destruction --
            //it can be bad or good depends on context but is good to cultivate
            //so you can know what you want to achieve or dont understand
            //a namespace is there to name stuff (duh) EX: FavColorNum.Program would call Program inside of FavColorNum
            //Be sure to run as start without debugging so it doesnt close instantly and do throughout 


            // Ask user for a colour in the console and store it in a variable
            Console.Write("What's your favourite colour? \t");

            // Save the answer
            // Using a variable
            string favColour = Console.ReadLine();

            // Ask user for a number in the console and store it in a variable
            Console.Write("\n What's your favourite number? \t");
            // Save the answer
            string favNumAns = Console.ReadLine();
            int favNumber = 0;
            try
            {
                favNumber = Convert.ToInt32(favNumAns);
            }
            catch
            {
                Console.WriteLine("That's not a number!\n");
            }
            //vv doesn't work well because if they input a string instead of a
            //number we will end up with some upset angry nonsense
            //int favNum = Convert.ToInt32(favNumAns);

            switch (favColour)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
            }

            // Print the user's colour the number of times given in the console
            for (int i = 0; i < favNum; i++)
            {
                Console.Write("Your favourite colour is " + favColour + " \n");
            }
            
        }
    }
}
