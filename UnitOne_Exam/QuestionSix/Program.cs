using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSix
{
    class Program
    {

        //Pretty sure this isn't what I was meant to do for this question nor does it work; 
        //plan to ask for assistance on this one later because delegates are hard 

        delegate void Reader(string s);

        static void Main(string[] args)
        {

            Reader log = new Reader(ReaderLine);

            Console.WriteLine("You said, " + log);



        }

        public static void ReaderLine(string reader)
        {
            Console.WriteLine("What do you want to say?");
            Console.ReadLine();
        }
    }
}
