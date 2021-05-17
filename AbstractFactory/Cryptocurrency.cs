namespace ConsoleApp1.AbstractFactory
{
    public abstract class Cryptocurrency
    {
        public decimal Volume { get; set; }
        public decimal Price { get; set; }

        public abstract void Buy(decimal volume);
        public abstract void Sell(decimal volume);
    }
}