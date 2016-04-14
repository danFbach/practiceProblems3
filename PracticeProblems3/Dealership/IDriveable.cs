using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeProblems3.Dealership;

namespace PracticeProblems3
{
    interface IDriveable<Vehicle>
    {
        void accelerate();
        void deccelerate();
        void returnToDealer();
    }
}
