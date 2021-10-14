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
            Console.Write("What's your sentence? \t");


            string replacing = Console.ReadLine();
            string cNo = "No";
            string ccNo = "NO";
            string lcNo = "nO";
            string lNo = "no";
            string cYes = "Yes";
            string ccYes = "YEs";
            string cccYes = "YES";
            string lclYes = "yEs";
            string lccYes = "yES";
            string clcYes = "YeS";
            string lYes = "yes";

            if (replacing.Contains(cNo) || replacing.Contains(ccNo) || replacing.Contains(lcNo) || replacing.Contains(lNo) || replacing.Contains(cYes) || replacing.Contains(ccYes) || replacing.Contains(cccYes) || replacing.Contains(lclYes) || replacing.Contains(lccYes) || replacing.Contains(clcYes) || replacing.Contains(lYes))
            {
                if (replacing.Contains(cNo)) {
                    replacing.Replace(cNo, cYes);
                    Console.WriteLine(replacing.Replace(cNo, cYes));

                } else if (replacing.Contains(ccNo)) {
                    replacing.Replace(ccNo, cccYes);
                    Console.WriteLine(replacing.Replace(ccNo, cccYes));

                } else if (replacing.Contains(lcNo)){
                    replacing.Replace(lcNo, lccYes);
                    Console.WriteLine(replacing.Replace(lcNo, lccYes));

                } else if (replacing.Contains(lNo)){
                    replacing.Replace(lNo, lYes);
                    Console.WriteLine(replacing.Replace(lNo, lYes));

                } else if (replacing.Contains(cYes)){
                    replacing.Replace(cYes, cNo);
                    Console.WriteLine(replacing.Replace(cYes, cNo));

                } else if (replacing.Contains(ccYes)){
                    replacing.Replace(ccYes, ccNo);
                    Console.WriteLine(replacing.Replace(ccYes, ccNo));

                } else if (replacing.Contains(cccYes)){
                    replacing.Replace(cccYes, lcNo);
                    Console.WriteLine(replacing.Replace(cccYes, lcNo));

                } else if (replacing.Contains(lclYes)){
                    replacing.Replace(lclYes, cYes);
                    Console.WriteLine(replacing.Replace(lclYes, cYes));

                } else if (replacing.Contains(lccYes)){
                    replacing.Replace(lccYes, lcNo);
                    Console.WriteLine(replacing.Replace(lccYes, lcNo));

                } else if (replacing.Contains(clcYes)){
                    replacing.Replace(clcYes, lcNo);
                    Console.WriteLine(replacing.Replace(clcYes, lcNo));

                } else if (replacing.Contains(lYes)){
                    replacing.Replace(lYes, lNo);
                    Console.WriteLine(replacing.Replace(lYes, lNo));

                }
            }
            else
            {
                Console.WriteLine("Your string did not have yes or no in it!");
            }

        }
    }
}
