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

            //PURPOSE: ask for the user's favourite colour and number and write the color the number of times (all in console)

            // Ask user for a colour in the console and store it in a variable
            // Ask the user for color in the console
           // Console.Write("What's your fav color? \t");

            // Save the answer
            // Use a variable
           // string favColor = Console.ReadLine();

            // Ask for a number
           // Console.Write("What's your fav number? \t");

            //ask for number
            //read number in
            //try and convert to number
            //if fails loop back to top
            //if succeed continue through
            Console.Write("What's your fav color? \t");

            // Save the answer
            // Use a variable
            string favColor = Console.ReadLine();
            
           
            int favNumber = 0;
             bool validNumGiven = false;
            do
            { 


                // Ask for a number
                Console.Write("What's your fav number? \t");
                //save the answer
                string favNumberAnswer = Console.ReadLine();

                try
                {
                    favNumber = Convert.ToInt32(favNumberAnswer);
                    validNumGiven = true;
                }
                catch
                {
                    Console.WriteLine("Not a number");
                    validNumGiven = false;
                }
                } while(validNumGiven == false);

            /*
            // save the answer
            string favNumberAnswer = Console.ReadLine();

            int favNumber = 0;
            try
            {
                favNumber = Convert.ToInt32(favNumberAnswer);
            }
            catch
            {
                Console.WriteLine("Nah, a number");
            }
            */

            switch (favColor)
            {
                case "purple":
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

            // Print out the color favNumber number of times
            for (int i = 0; i < favNumber; i++)
            {
                Console.WriteLine("Your favorite color is " + favColor);
            }

        }
    }
}