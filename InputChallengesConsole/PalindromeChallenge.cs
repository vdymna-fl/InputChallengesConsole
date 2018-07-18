using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputChallengesConsole
{
    public class PalindromeChallenge : Challenge
    {
        private string _userInputValue;

        public override void Execute()
        {
            HandleUserInput();

            CheckForPalindrome();

            base.Execute();
        }

        private void HandleUserInput()
        {
            Console.WriteLine("Enter a value that you would like to check as palindrome");
            while (String.IsNullOrEmpty(_userInputValue))
            {
                _userInputValue = Console.ReadLine();

                if (String.IsNullOrEmpty(_userInputValue))
                {
                    Console.WriteLine("You can't enter a blank value, please try again");
                }
            }
            
            // cleanse the string by removing all not letter char
            _userInputValue = StringHelper.RemoveNonLetters(_userInputValue);
            Console.WriteLine($"You've entered => {_userInputValue} (non-letter characters are ignored)");
        }

        private void CheckForPalindrome()
        {
            char[] charArray = _userInputValue.ToCharArray();
            Array.Reverse(charArray);
            string reversedInputString = new string(charArray);

            if (_userInputValue == reversedInputString)
            {
                Console.WriteLine("Congrats you have a palindrome");
            }
            else
            {
                Console.WriteLine("Sorry not a palindrome");
            }
        }
    }
}
