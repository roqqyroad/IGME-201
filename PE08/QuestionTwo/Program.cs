using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool Write()
            {
                Console.WriteLine("Text output from function.");
            }

            static void myFunction(string label, params int[] args, bool showLabel)
            {
                if (showLabel)
                {
                    Console.WriteLine(label);
                }

                foreach (int i in args)
                {
                    Console.WriteLine("{0}", i);
                }
            }

        }
    }
}
