using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputChallengesConsole
{
    public class Challenge
    {
        public virtual void Execute()
        {
            Console.WriteLine("Press any key to start over...");
            Console.ReadKey();
        }
    }
}
