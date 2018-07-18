using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputChallengesConsole
{
    public class PermutationChallenge : Challenge
    {
        private List<int> _firstIntegerList = new List<int>();
        private List<int> _secondIntegerList = new List<int>();

        private const string INVALID_INPUT_TEXT = "Invalid integer was entered, please try again";

        public override void Execute()
        {
            HandleUserInput();

            CheckForPermutation();

            base.Execute();
        }

        private void HandleUserInput()
        {
            PopulateIntegerList(_firstIntegerList, "the first array");

            PopulateIntegerList(_secondIntegerList, "the second array");
        }

        private void PopulateIntegerList(List<int> integerList, string arrayName)
        {
            Console.WriteLine($"Enter the {arrayName} of 11 numbers (one at a time)");
            while (integerList.Count < 11)
            {
                string nbrInput = Console.ReadLine();

                if (int.TryParse(nbrInput, out var validInt))
                {
                    integerList.Add(validInt);
                }
                else
                {
                    Console.WriteLine(INVALID_INPUT_TEXT);
                }
            }
            Console.WriteLine($"You've entered => {String.Join(" ", integerList)}");
        }

        private void CheckForPermutation()
        {
            string firstIntegerListOrderedAsString = String.Join("", _firstIntegerList.OrderBy(i => i));
            string secondIntegerListOrderedAsString = String.Join("", _secondIntegerList.OrderBy(i => i));

            if (firstIntegerListOrderedAsString == secondIntegerListOrderedAsString)
            {
                Console.WriteLine("Congrats you have a permutation");
            }
            else
            {
                Console.WriteLine("Sorry not a permutation");
            }
        }
    }
}
