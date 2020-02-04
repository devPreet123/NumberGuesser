using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();  // Run GetAppInfo function

            GreetUser(); //Ask for username

            while (true)
            {
                Random random = new Random();
                int CorrectNumber = random.Next(1, 10);
                int Guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (Guess != CorrectNumber)
                {
                    string Input = Console.ReadLine();

                    if (!int.TryParse(Input, out Guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");
                        continue;
                    }

                    Guess = Int32.Parse(Input);

                    if (Guess != CorrectNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number,please try again");
                    }
                }
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");
                Console.WriteLine("Play again? [Y or N]");
                string Answer = Console.ReadLine().ToUpper();
                if (Answer == "Y")
                {
                    continue;
                }
                else if(Answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string AppName = "Number Guesser";
            string AppVersion = "1.0.0";
            string AppAuthor = "DevPreet Pastry";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}:Version {1} by {2}", AppName, AppVersion, AppAuthor);
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string InputName = Console.ReadLine();
            Console.WriteLine("Hello {0} let's play a game...", InputName);
        }
        static void PrintColorMessage(ConsoleColor color, string Message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Message);
            Console.ResetColor();
        }
    }
}
