using System;

namespace ConsoleApp1.Memento
{
    public class Program
    {
        public static void Main()
        {
            Game game = new Game(1, 2137.22f);
            game.CreateMemento();

            game.Level = 2;
            game.Position = 1488.69420f;
            Console.WriteLine($"{game.Level}, {game.Position}");
            game.RestoreMemento();
            Console.WriteLine($"{game.Level}, {game.Position}");

        }
    }
}