using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validatedNum;
            bool validatedPower;

            int num = 0;
            do
            {


                // Ask for a number
                Console.WriteLine("What number do you want the first value to be?");
                //save the answer
                string strNum = Console.ReadLine();

                try
                {
                    num = Convert.ToInt32(strNum);
                    validatedNum = true;
                }
                catch
                {
                    Console.WriteLine("That's not a valid number. Please try again");
                    validatedNum = false;
                }
            } while (validatedNum == false);


            int pow = 0;
            do
            {


                // Ask for a number
                Console.WriteLine("What number do you want the second value to be?");
                //save the answer
                string strPow = Console.ReadLine();

                try
                {
                    pow = Convert.ToInt32(strPow);
                    validatedPower = true;
                }
                catch
                {
                    Console.WriteLine("That's not a valid number. Please try again");
                    validatedPower = false;
                }
            } while (validatedPower == false);

            Console.WriteLine("The result of " + num + " to the power of " + pow + " = " + Pwr(num, pow));

        }

        public static int Pwr (int number, int powerLvl)
        {
            //if the power level increased to is not zero
            if (powerLvl != 0)
            {
                //return the power function with the power level lowered by one, repeats through! until 0
                return (number * Pwr(number, powerLvl - 1));
            }
            
            return 1;
        }
    }
}
