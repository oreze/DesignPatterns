namespace ConsoleApp1.AbstractFactory
{
    public interface CryptoAbstractFactory
    {
        public Wallet CreatWallet();
        public Cryptocurrency CreateCrypto();
    }
}