using System;

namespace ConsoleApp1.AbstractFactory
{
    public class Bitcoin : Cryptocurrency
    {
        public override void Buy(decimal volume)
        {
            Console.WriteLine($"Bought {volume} bitcoins");
        }

        public override void Sell(decimal volume)
        {
            if (Volume - volume >= 0)
            {
                Console.WriteLine($"Sold {volume} bitcoins");
                Volume -= volume;
            }
            else
            {
                Console.WriteLine("Cant send that much bitcoins");
            }
        }

        public void ReachNewAth()
        {
            Console.WriteLine("DID HE JUST MADE A TWEET? PRICE IS 2 TIMER HIGHER");
            Price *= 1.2m;
        }
    }
}