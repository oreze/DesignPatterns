using System;
using System.Threading;

namespace ConsoleApp1.Command
{
    public class Program
    {
        public static void Main()
        {
            Controller controller = new Controller();
            Wallet wallet = new Wallet();

            while (true)
            {
                var random = new Random();
                var randomCommand = random.NextDouble();

                if (randomCommand < 0.75)
                {
                    var command = new Buy(wallet);
                    controller.AddCommand(command);
                    Console.WriteLine($"[{DateTime.Now} BUY] Add buy command to queue.");
                }
                else
                {
                    var command = new Sell(wallet);
                    controller.AddCommand(command);
                    Console.WriteLine($"[{DateTime.Now} SELL] Add sell command to queue.");
                }
                
                Thread.Sleep(1000);

                randomCommand = random.NextDouble();
                
                if (randomCommand < 0.8) 
                    controller.Execute();
                else
                    controller.Undo();
                
                Thread.Sleep(1000);
                    
            }
        }
    }
}