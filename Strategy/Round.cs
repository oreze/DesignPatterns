namespace ConsoleApp1.Strategy
{
    public class Round
    {
        private Strategy _strategy { get; set; } = new RushA();

        public void SetStrategy(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void Execute()
        {
            _strategy.Execute();
        }

    }
}