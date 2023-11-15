using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Strategy;

namespace ZooSimulator.Context.TypesOfBirds
{
    internal class RubberDuck : Bird
    {
        public RubberDuck(IFlight flighttype) : base(flighttype)
        {
        }
        public static void Sound()
        {
            Console.WriteLine("It makes sqeak noise ");
        }
    }
}
