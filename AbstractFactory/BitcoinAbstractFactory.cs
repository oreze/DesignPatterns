using System;

namespace ConsoleApp1.AbstractFactory
{
    public class BitcoinAbstractFactory: CryptoAbstractFactory
    {
        public Wallet CreatWallet()
        {
            Console.WriteLine("Created new TrustWallet");
            return new TrustWallet();
        }

        public Cryptocurrency CreateCrypto()
        {
            Console.WriteLine("Created new bitcoin instance (idk what i`m doing)");
            return new Bitcoin();
        }
    }
}