using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionNine
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            //tells what separates each word for us
            char[] separator = { ' ' };
            //asks for string
            Console.WriteLine("what's your string? \t");
            //and stores it
            str = Console.ReadLine();
            //array for the words
            string[] word;
            //and fills the array using the separator above
            word = str.Split(separator);

            Console.WriteLine("Your string had the words:");
            //and now we write all of it
            foreach (string aWord in word)
            {
                Console.Write("\"{0}\" ", aWord);
            }
            //written!

        }
        }
}
