using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputChallengesConsole
{
    class Program
    {
        private const string EXIT = "exit";
        private const string PRESS_ANY_KEY = "Press any key to try again...";

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose a challenge...\r\n" +
                                  $"Enter {(int)ChallengeTypes.Permutation} for Permutation challenge\r\n" +
                                  $"Enter {(int)ChallengeTypes.TheSecond} for The Second challenge\r\n" +
                                  $"Enter {(int)ChallengeTypes.Palindrome} for Palindrome challenge\r\n" +
                                  $"Enter {EXIT} to quit");

                string userInput = Console.ReadLine();

                // try parsing input integer as Challenges enum
                if (Enum.TryParse<ChallengeTypes>(userInput, out var selectedChallenge) && 
                    Enum.IsDefined(typeof(ChallengeTypes), selectedChallenge))
                {
                    if (selectedChallenge == ChallengeTypes.Permutation)
                    {
                        PermutationChallenge permutation = new PermutationChallenge();
                        permutation.Execute();
                    }
                    else if (selectedChallenge == ChallengeTypes.TheSecond)
                    {
                        Console.WriteLine("This challenge is coming in the next release");
                        Console.WriteLine(PRESS_ANY_KEY);
                        Console.ReadKey();
                    }
                    else if (selectedChallenge == ChallengeTypes.Palindrome)
                    {
                        PalindromeChallenge palindrome = new PalindromeChallenge();
                        palindrome.Execute();
                    }
                }
                else if (userInput == EXIT)
                {
                    // exit the console app
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid challenge selection");
                    Console.WriteLine(PRESS_ANY_KEY);
                    Console.ReadKey();
                }
            }
        }
    }
}
