using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //member variables
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        Dictionary<int, Contestant> contestants;        

        //constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestant.firstName = UserInterface.GetUserInputFor("Enter your first name.");
            contestant.lastName = UserInterface.GetUserInputFor("Enter your last name.");
            contestant.email = UserInterface.GetUserInputFor("Enter your email address");
            contestant.registrationNumber = contestants.Count;
        }

        public Contestant PickWinner()
        {           
            //Random random = new Random();
            //int winningRegNumber = random.Next(contestants.Count);
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant's first name: " + contestant.firstName);
            Console.WriteLine("Contestant's last name: " + contestant.lastName);
            Console.WriteLine("Contestant's email address: " + contestant.email);
        }
    }
}
