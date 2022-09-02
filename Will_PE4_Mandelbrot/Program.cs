using System;

namespace Will_PE4_Mandelbrot
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
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            double realCoordStart, realCoordEnd, realCoordInc;
            double imagCoordStart, imagCoordEnd, imagCoordDec;
            bool valid = false;

            do
            {
                Console.Write("Enter start value for realCoord (default -0.6): ");
                realCoordStart = double.Parse(Console.ReadLine());

                Console.Write("Enter an end value for realCoord (default 1.77): ");
                realCoordEnd = double.Parse(Console.ReadLine());

                if (realCoordStart >= realCoordEnd)
                {
                    Console.WriteLine("The start value must be less than the end value! Please enter again.");
                }
                else
                {
                    valid = true;
                }
            }
            while (valid == false);

            realCoordInc = (realCoordEnd - realCoordStart) / 80;

            valid = false;

            do
            {
                Console.Write("Enter start value for imagCoord (default 1.2): ");
                imagCoordStart = double.Parse(Console.ReadLine());

                Console.Write("Enter an end value for imagCoord (default -1.2): ");
                imagCoordEnd = double.Parse(Console.ReadLine());

                if (imagCoordStart <= imagCoordEnd)
                {
                    Console.WriteLine("The start value must be greater than the end value! Please enter again.");
                }
                else
                {
                    valid = true;
                }
            }
            while (valid == false);

            imagCoordDec = (imagCoordStart - imagCoordEnd) / 48;

            for (imagCoord = imagCoordStart; imagCoord >= imagCoordEnd; imagCoord -= imagCoordDec)
                
                for (realCoord = realCoordStart; realCoord <= realCoordEnd; realCoord += realCoordInc)
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
                }
                Console.Write("\n");
            }

        }
    }

