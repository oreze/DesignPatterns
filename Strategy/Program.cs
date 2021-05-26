namespace ConsoleApp1.Strategy
{
    public class Program
    {
        public static void Main()
        {
            var round = new Round();
            round.Execute();

            var rushB = new RushB();
            round.SetStrategy(rushB);
            round.Execute();
        }
    }
}