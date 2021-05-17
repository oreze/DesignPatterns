using System;

namespace ConsoleApp1.AbstractFactory
{
    public class TrustWallet: Wallet
    {
        public override void Send(decimal volume)
        {
            if (Volume - volume >= 0)
            {
                Console.WriteLine($"Send {volume} bitcoins");
                Volume -= volume;
            }
            else
            {
                Console.WriteLine("Cant send that much bitcoins");
            }
        }
    }
}