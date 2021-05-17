using System;

namespace ConsoleApp1.AbstractFactory
{
    public class Doge : Cryptocurrency
    {
        public override void Buy(decimal volume)
        {
            Console.WriteLine($"Bought {volume} doge");
        }

        public override void Sell(decimal volume)
        {
            if (Volume - volume >= 0)
            {
                Console.WriteLine($"Sold {volume} doge");
                Volume -= volume;
            }
            else
            {
                Console.WriteLine("Cant send that much doge");
            }
        }

        public void GetBoostedByElon()
        {
            Console.WriteLine("DID HE JUST MADE A TWEET? PRICE IS 2 TIMER HIGHER");
            Price *= 2;
        }
    }
}