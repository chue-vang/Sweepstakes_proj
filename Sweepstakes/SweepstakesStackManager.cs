using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //member variables
        public Stack<Sweepstakes> stack;



        //consructor
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        


        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();            
        }
    }
}
