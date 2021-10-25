using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;


namespace QuestionSeven
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Timer timeOutTimer;
            int qNum = 0;
            bool validNumGiven = false;

            do
            {


                // Ask for a number
                Console.WriteLine("Choose your question (1-3): \t");
                //save the answer
                string qNumAns = Console.ReadLine();

                try
                {
                    qNum = Convert.ToInt32(qNumAns);
                    validNumGiven = true;
                }
                catch
                {
                    validNumGiven = false;
                }
            } while (validNumGiven == false);

            bool timedOut = false;
            timeOutTimer = new Timer(5000);
            timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);

            timeOutTimer.Start();

            string qAns ="";
            do
            {
                //gets question according to what number you give
                if (qNum == 1)
                {
                    Console.WriteLine("\nYou have 5 seconds to answer the following question:");
                    Console.WriteLine("What is your favorite color?\n");

                    qAns = Console.ReadLine();
                    timeOutTimer.Stop();

                }
                else if (qNum == 2)
                {
                    Console.WriteLine("\nYou have 5 seconds to answer the following question:");
                    Console.WriteLine("What is the answer to life, the universe and everything?\n");

                    qAns = Console.ReadLine();
                    timeOutTimer.Stop();

                }
                else if (qNum == 3)
                {
                    Console.WriteLine("\nYou have 5 seconds to answer the following question:");
                    Console.WriteLine("What is the airspeed velocity of an unladen swallow?\n");

                    qAns = Console.ReadLine();
                    timeOutTimer.Stop();

                }
                if (timedOut)
                {
                    qAns = "a";
                    Console.WriteLine("Time's up!");
                    Console.WriteLine("The answer is: ");
                    if (qNum == 1)
                    {
                        Console.Write("black\n\n");
                        Console.WriteLine("Play again? ");
                        string pAAns = Console.ReadLine();
                        if (pAAns == "yes")
                        {
                            goto start;
                        }
                    }
                    else if (qNum == 2)
                    {
                        Console.Write("42\n\n");
                        Console.WriteLine("Play again? ");
                        string pAAns = Console.ReadLine();
                        if (pAAns == "yes")
                        {
                            goto start;
                        }
                    }
                    else if (qNum == 3)
                    {
                        Console.Write("What do you mean? African or European swallow?\n\n");
                        Console.WriteLine("Play again? ");
                        string pAAns = Console.ReadLine();
                        if (pAAns == "yes")
                        {
                            goto start;
                        }
                    }


                }

                try
                {
                    //if qnum has the correct qans will run well done and play again stuff
                    if ((qNum == 1 && qAns == "black") || (qNum == 2 && qAns == "42") || (qNum == 3 && qAns == "What is the airspeed velocity of an unladen swallow?"))
                    {
                        Console.WriteLine("Well done!");
                        Console.WriteLine("Play again? ");
                        string pAAns = Console.ReadLine();
                        if (pAAns == "yes")
                        {
                            goto start;
                        }
                    }
                    //else its wrong and grabs you correct answer
                    else
                    {
                        Console.WriteLine("Wrong!\t");
                        if (qNum == 1)
                        {
                            Console.Write("The answer is: black");
                            Console.WriteLine("\nPlay again? ");
                            string pAAns = Console.ReadLine();
                            if (pAAns == "yes")
                            {
                                goto start;
                            }
                        }
                        else if (qNum == 2)
                        {
                            Console.Write("The answer is: 42");
                            Console.WriteLine("\nPlay again? ");
                            string pAAns = Console.ReadLine();
                            if (pAAns == "yes")
                            {
                                goto start;
                            }
                        }
                        else if (qNum == 3)
                        {
                            Console.Write("The answer is: What do you mean? African or European swallow?");
                            Console.WriteLine("\nPlay again? ");
                            string pAAns = Console.ReadLine();
                            if (pAAns == "yes")
                            {
                                goto start;
                            }
                        }
                    }
                }

                catch
                {
                }

            } while (!timedOut);

            


            void TimesUp(object source, ElapsedEventArgs e)
            {
                Console.WriteLine();
                qAns = "a";
                Console.WriteLine("Time's up!");
                Console.WriteLine("The answer is: ");
                if (qNum == 1)
                {
                    Console.Write("black");
                }
                else if (qNum == 2)
                {
                    Console.Write("42");
                }
                else if (qNum == 3)
                {
                    Console.Write("What do you mean? African or European swallow?");
                }
                timedOut = true;
                timeOutTimer.Stop();

            }

        }
    }
}
