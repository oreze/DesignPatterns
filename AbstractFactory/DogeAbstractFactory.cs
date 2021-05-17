using System;

namespace ConsoleApp1.AbstractFactory
{
    public class DogeAbstractFactory: CryptoAbstractFactory
    {
        public Wallet CreatWallet()
        {
            Console.WriteLine("Created new DogeWallet");
            return new DogeWallet();
        }

        public Cryptocurrency CreateCrypto()
        {
            Console.WriteLine("Created new doge instance (idk what i`m doing)");
            return new Doge();
        }
    }
}