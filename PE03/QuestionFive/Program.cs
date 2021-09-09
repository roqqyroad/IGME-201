using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 0;
            int numTwo = 0;
            int numThree = 0;
            int numFour = 0;
            bool validNumGiven = false;
            do
            {


                
                Console.Write("What's your first number? \t");
                string numOneAns = Console.ReadLine();

                Console.Write("What's your secpnd number? \t");
                string numTwoAns = Console.ReadLine();

                Console.Write("What's your third number? \t");
                string numThreeAns = Console.ReadLine();

                Console.Write("What's your fourth number? \t");
                string numFourAns = Console.ReadLine();

                try
                {
                    numOne = Convert.ToInt32(numOneAns);
                    numTwo = Convert.ToInt32(numTwoAns);
                    numThree = Convert.ToInt32(numThreeAns);
                    numFour = Convert.ToInt32(numFourAns);
                    validNumGiven = true;
                }
                catch
                {
                    Console.WriteLine("One or more of your inputted values was not an int");
                    validNumGiven = false;
                }
            } while (validNumGiven == false);
            Console.WriteLine((numOne * numTwo * numThree * numFour));
        }
    }
}
