using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Strategy;

namespace ZooSimulator.Context.TypesOfBirds
{
    internal class Eagle : Bird
    {
        public float Speed { get; set; }
        public float Vision_range { get; set; }
        public Eagle(IFlight flighttype) : base(flighttype)
        {
        }
        public static void Perch()
        {
            Console.WriteLine("It perchs in tree!");
        }
        public static void SearchForPrey()
        {
            Console.WriteLine("It's searching for prey");
        }
    }
}
