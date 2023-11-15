using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Strategy;

namespace ZooSimulator.Context.TypesOfBirds
{
    internal class Ostrich : Bird
    {
        public string? Height { get; set; }
        public string? Speed { get; set; }
        public Ostrich(IFlight flighttype) : base(flighttype)
        {
        }
        public static void Run()
        {
            Console.WriteLine("It runs fast!");
        }
    }
}
