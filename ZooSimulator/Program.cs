using ZooSimulator.Context;
using ZooSimulator.Context.TypesOfBirds;
using ZooSimulator.Strategy;
using ZooSimulator.Strategy.ConcreteStrategy;

class Program
{
    public static void Main(String[] args)
    {
        // First let's make some behaviours of birds.
        IFlight flapflight = new FlapWings();
        IFlight slideFly = new Slides();
        IFlight nofly = new NoFly();
        IFlight floats = new Floats();

        Bird mallardDuck = new MallardDuck(flapflight);
        mallardDuck.Name = "Mallard Duck's";
       
       
    }
}