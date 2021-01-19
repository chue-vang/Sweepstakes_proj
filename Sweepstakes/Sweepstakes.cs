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
        }

        public Contestant PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
