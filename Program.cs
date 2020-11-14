using System;

namespace MiniTrivia
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            do
            {
                Console.WriteLine("Choose a trivia category: (1) Sports (2) Science (3) Pop Culture or select (4) to Quit");

                string userInput;
                int userChoice = sbyte.Parse(Console.ReadLine());
                int tries = 0;

                switch (userChoice)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Which team won the 2020 NBA Championship?");
                            userInput = Console.ReadLine().ToLower();

                            if (userInput == "lakers" || userInput == "los angeles")
                            {
                                Console.WriteLine("That's correct!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Try again");
                                tries = tries + 1;
                                Console.WriteLine($"You have used {tries}/3 attempts");
                            }
                            if (tries == 3)
                            {
                                Console.WriteLine("You have exceed the allowed attempts");
                            }

                        } while (tries < 3);

                        break;

                    case 2:

                        do
                        {
                            Console.WriteLine("What is the fastest land snake in the world?");
                            userInput = Console.ReadLine().ToLower();

                            if (userInput == "mamba" || userInput == "black mamba")
                            {
                                Console.WriteLine("That's correct!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Try again");
                                tries = tries + 1;
                                Console.WriteLine($"You have used {tries}/3 attempts");
                            }
                            if (tries == 3)
                            {
                                Console.WriteLine("You have exceed the allowed attempts");
                            }


                        } while (tries < 3);
                        break;

                    case 3:
                        do
                        {
                            Console.WriteLine("What city is Big Sean from");
                            userInput = Console.ReadLine().ToLower();

                            if (userInput == "detroit")
                            {
                                Console.WriteLine("That's correct!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Try again");
                                tries = tries + 1;
                                Console.WriteLine($"You have used {tries}/3 attempts");
                            }
                            if (tries == 3)
                            {
                                Console.WriteLine("You have exceed the allowed attempts");
                            }
                        } while (tries < 3);

                        break;

                    case 4:

                        Console.WriteLine("Thanks for playing!");
                        quit = true;
                        break;

                    default:

                        Console.WriteLine("Select a valid number");
                        break;

                }
            } while (quit != true);
        }
    }
}
