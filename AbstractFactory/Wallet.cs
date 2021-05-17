namespace ConsoleApp1.AbstractFactory
{
    public abstract class Wallet
    {
        public decimal Volume { get; set; }

        public abstract void Send(decimal volume);
    }
}