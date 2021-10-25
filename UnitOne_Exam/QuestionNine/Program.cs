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
            string Name = "Rachel";
            double dSalary = 30000;
            Console.WriteLine("What is your name?\t");
            string name = Console.ReadLine();
            if (name == Name)
            {

                Console.WriteLine("Congrats! You got a raise! Your salary is now: \t" + (dSalary + 19999.99));
                GiveRaise(employee);
            }
            else
            {
                Console.WriteLine("Sorry, no raise");
            }

        }
        struct employee
        {
            public string sName;
            public double dSalary;

        }
        static bool GiveRaise(employee)
        {
            string Name = "Rachel";
            double dSalary = 30000;
            if (employee.sName == Name)
            {
                employee.dSalary += 19999.99;

                return true;
            }
            else
            {

                return false;
            }
        }
    }
}