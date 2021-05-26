using System;

namespace ConsoleApp1.Command
{
    public class Sell: Command
    {
        private Wallet _wallet { get; }
        private decimal _amount { get; set; }

        public Sell(Wallet wallet)
        {
            _wallet = wallet;
        }

        public void Execute()
        {
            decimal RandomDecimal = (decimal)new Random().NextDouble();
            if (_wallet.Amount - RandomDecimal >= 0m)
            {
                _amount = RandomDecimal;
                _wallet.Amount -= RandomDecimal;
                Console.WriteLine($"[{DateTime.Now} SELL] Selling {_amount} of some crypto. " +
                                  $"Wallet amount is {_wallet.Amount}.");
            }
            else
            {
                Console.WriteLine($"[{DateTime.Now} SELL] Cannot sell {RandomDecimal} of some crypto. " +
                                  $"Wallet amount would be lower than 0.");
            }
        }

        public void Undo()
        {
            _wallet.Amount += _amount;
            Console.WriteLine($"[{DateTime.Now} SELL] Undo selling {_amount} of some crypto. " +
                              $"Wallet amount is {_wallet.Amount}.");
        }
    }
}