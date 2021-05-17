using System;

namespace ConsoleApp1.AbstractFactory
{
    public class DogeWallet: Wallet
    {
        public override void Send(decimal volume)
        {
            if (Volume - volume >= 0)
            {
                Console.WriteLine($"Send {volume} doge");
                Volume -= volume;
            }
            else
            {
                Console.WriteLine("Cant send that much doge");
            }
        }
    }
}