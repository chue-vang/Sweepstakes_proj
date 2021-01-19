using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        public string GetUserInputFor(string prompt)
        {
            Console.WriteLine();
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
