using System;

//Namespace
namespace Guess_A_Number
{   // Main Class
    class Program
    {   // Entry Level Main
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function
            GreetUser(); // Ask for users name and greet
            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        continue;
                    }

                    guess = Int32.Parse(input);
                    if (guess != correctNumber)
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                }
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");
                Console.WriteLine("Do you want to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                    continue;
                else
                    return;
            }
        }
        // Get and display app info
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Matija Marić";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game !", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
