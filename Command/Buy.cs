using System;

namespace ConsoleApp1.Command
{
    public class Buy: Command
    {
        private Wallet _wallet { get; }
        private decimal _amount { get; set; }

        public Buy(Wallet wallet)
        {
            _wallet = wallet;
        }

        public void Execute()
        {
            decimal RandomDecimal = (decimal)new Random().NextDouble();
            _amount = RandomDecimal;
            _wallet.Amount += RandomDecimal;
            Console.WriteLine($"[{DateTime.Now} BUY] Buy {RandomDecimal} of some crypto. " +
                              $"Wallet amount is {_wallet.Amount}.");
        }

        public void Undo()
        {
            if (_wallet.Amount - _amount >= 0m)
            {
                _wallet.Amount -= _amount;
                Console.WriteLine($"[{DateTime.Now} BUY] Undo buying {_amount} of some crypto. " +
                                  $"Wallet amount is {_wallet.Amount}.");
            }
            else
            {
                Console.WriteLine($"[{DateTime.Now} BUY] Cannot undo buying {_amount} of some crypto. " +
                                  $"Wallet amount would be lower than 0.");
            }
        }
    }
}