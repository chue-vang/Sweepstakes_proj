using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;

        //constructor
        public Contestant()
        {
            firstName = "";
            lastName = "";
            email = "";
            registrationNumber = 0;
        }
}
