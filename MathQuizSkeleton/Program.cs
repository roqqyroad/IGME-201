using System.IO;
using System;

class Program
{
    static void Main()
    {
        // constant for setting difficulty with 1 variable
        const int MAX_BASE = 10;

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        // seed the random number generator
        Random rand = new Random();

        Console.WriteLine("Math Quiz!");
        Console.WriteLine();

        // fetch the user's name into myName          
        string myName = "";
        bool  hasName = false;

        while (hasName == false)
        {
            Console.Write("What is your name-> ");
            myName = Console.ReadLine();
            if (myName.Length > 0)
            {
                hasName = true;
            }
            

        }

        Console.WriteLine();

        // ask how many questions until they enter a valid number
        int numQuestions = 0;

        bool successfulParse = false;
        do
        {
            Console.Write("How many questions-> ");

            string input = Console.ReadLine();
            successfulParse = int.TryParse(input, out numQuestions);
        } while (!successfulParse);

        Console.WriteLine();

        // ask difficulty level until they enter a valid response
        string sDifficulty = "";
        bool difficultyChosen = false;
        do
        {
            Console.Write("Difficulty level (easy, medium, hard)-> ");
            sDifficulty = Console.ReadLine();
            //Makes all lowercase incase the user enters it in caps
            sDifficulty = sDifficulty.ToLower();

            difficultyChosen =
                 (sDifficulty == "easy") || (sDifficulty == "medium") || (sDifficulty == "hard");

        } while (!difficultyChosen);

        Console.WriteLine();

        // if they choose easy, then set nMaxRange = MAX_BASE
        // if they choose medium, set nMaxRange = MAX_BASE * 2
        // if they choose hard, set nMaxRange = MAX_BASE * 3
        int nMaxRange = 0;

        switch (sDifficulty)
        {
            case "easy":
                nMaxRange = MAX_BASE;
                break;
            case "medium": 
                nMaxRange = MAX_BASE * 2;
                break;
            case "hard":
                nMaxRange = MAX_BASE * 3;
                break;
        }

        // initialize correct responses for each time around
        int numCorrect = 0;

        // ask each question
        for (int i = 0; i < numQuestions; i++)
        {
            // generate a random number between 0 inclusive and 3 exclusive to get the operation
            int op = rand.Next(0, 3);

            int val1 = rand.Next(0, nMaxRange) + nMaxRange;
            int val2 = rand.Next(0, nMaxRange);

            // if either argument is 0, pick new numbers

            // if nOp == 0, then addition
            // if nOp == 1, then subtraction
            // else multiplication
            int correctAnswer = 0;

            // display the question and prompt for the answer until they enter a valid number

            string sResponse = "";
            Int32 nResponse = 0;

            do
            {
            } while ( );

            // if response == answer, output flashy reward and increment # correct
            // else output stark answer

            // restore the screen colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
        }

        Console.WriteLine();

        // output how many they got correct and their score

        Console.WriteLine();
    }
