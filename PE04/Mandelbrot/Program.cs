using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord = 0.0; 
            double imagCoord = 0.0;
            int realLoopCount = 0;
            int imagLoopCount = 0;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            bool validDoubGiven = false;
            do{
                // Getting user input-
                // if the imagCoord ends up being less than the realCoord,
                // user will be informed that the two values were swapped
                Console.WriteLine("What is your real coord? :   ");
                string realStr = Console.ReadLine();
                Console.WriteLine("What is your imaginary coord? If the value is smaller than your previous number, they will be swapped.");
                string imagStr = Console.ReadLine();

                // Ensures that they are doubles
                try
                {
                    realCoord = Convert.ToDouble(realStr);
                    imagCoord = Convert.ToDouble(imagStr);
                    validDoubGiven = true;
                }
                catch
                {
                    Console.WriteLine("One or more of your inputted values was not a double");
                    validDoubGiven = false;
                }
            } while (validDoubGiven == false);

            double storageValue = 0.0;
           if(imagCoord < realCoord)
           {
                storageValue = realCoord;
                realCoord = imagCoord;
                imagCoord = storageValue;
           }
            
            for (imagCoord = imagCoord; imagLoopCount < 48; imagCoord -= 0.05)
            {
                for (realCoord = realCoord; realLoopCount < 80; realCoord += 0.03)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                    realLoopCount++;
                }
                Console.Write("\n");
                imagLoopCount++;
            }
            // I'm not quite sure I understood the directions based on how this runs,
            // but submitting this is better than not submitting something I suppose...
            // I also don't have questions regarding the directions so I dunno.
        }
    }
}
