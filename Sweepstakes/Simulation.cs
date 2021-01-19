using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            //here you will call the factory method to create a manager, save it as a variable
            //Pass the created manager into a MarketingFirm instantiation
            string userInput = UserInterface.GetUserInputFor("Select either a Stack manager or a Queue manager");
            MarketingFirm marketingFirm = new MarketingFirm(ManageSweepstakesObject(userInput));
        }

        public ISweepstakesManager ManageSweepstakesObject(string userInput)
        {
            switch (userInput)
            {
                case "Stack":
                    return new SweepstakesStackManager();
                case "Queue":
                    return new SweepstakesQueueManager();
                default:
                    throw new ApplicationException(string.Format("Not a valid selection."));
            }
        }
    }
}
