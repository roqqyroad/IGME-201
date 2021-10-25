using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionEight
{
    class Program
    {
        static void Main(string[] args)
        {
            string sName = "Rachel";
            double dSalary = 30000;
            Console.WriteLine("What is your name?\t");
            string name = Console.ReadLine();
            if (name == sName)
            {
                
                Console.WriteLine("Congrats! You got a raise! Your salary is now: \t" + (dSalary + 19999.99));
                GiveRaise(name, ref dSalary);
            }
            else
            {
                Console.WriteLine("Sorry, no raise");
            }

        }
        static bool GiveRaise(string name, ref double salary)
        {
            string sName = "Rachel";
            double dSalary = 30000;
            if (name == sName)
            {
                dSalary += 19999.99;

                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
