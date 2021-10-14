using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's the string you want reversed? \t");

            // Save the answer
            // Use a variable
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            string outputStr = new string(arr);
            Console.WriteLine("The string you put in to be reversed would be: \n" + outputStr);
        }
    }
}
