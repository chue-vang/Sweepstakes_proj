using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //member variables
        public ISweepstakesManager _manager;

        //constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this._manager = manager;
        }
        
        //member methods
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInputFor("What is the name of this new sweepstake?"));
            _manager.InsertSweepstakes(sweepstakes);
        }
    }
}
