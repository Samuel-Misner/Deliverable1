using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double FIDGET_SPINNERS_PER_INCH = 3.5;
            const int MEMES_PER_FOOT = 5;
            bool run = true;

            while (run)
            {
                bool validInput = false;
                string typeInput = "";
                double amountInput = 0;

                Console.Write("Please input a measurement type: ");

                while (!validInput)
                {
                    typeInput = Console.ReadLine();
                    if (!(typeInput == "fidget spinners" || typeInput == "memes" || typeInput == "inches" || typeInput == "feet"))
                    {
                        Console.Write("Please enter a valid measurement type: ");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                validInput = false;

                Console.Write("Please input an amount of " + typeInput + ": ");

                while (!validInput)
                {
                    if (!double.TryParse(Console.ReadLine(), out amountInput))
                    {
                        Console.Write("Please enter a valid measurement amount: ");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                if (typeInput == "fidget spinners")
                {
                    Console.WriteLine(amountInput + " " + typeInput + " is equal to " + (amountInput / FIDGET_SPINNERS_PER_INCH) + " inches.");
                }
                else if (typeInput == "memes")
                {
                    Console.WriteLine(amountInput + " " + typeInput + " is equal to " + (amountInput / MEMES_PER_FOOT) + " feet.");
                }
                else if (typeInput == "inches")
                {
                    Console.WriteLine(amountInput + " " + typeInput + " is equal to " + (amountInput * FIDGET_SPINNERS_PER_INCH) + " fidget spinners.");
                }
                else if (typeInput == "feet")
                {
                    Console.WriteLine(amountInput + " " + typeInput + " is equal to " + (amountInput * MEMES_PER_FOOT) + " memes.");
                }

                Console.WriteLine("Would you like to make another conversion?");

                if (Console.ReadLine() != "yes")
                {
                    run = false;
                }
            }
        }
    }
}
