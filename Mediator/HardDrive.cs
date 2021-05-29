using System;
using System.Threading;

namespace ConsoleApp1.Mediator
{
    public class HardDrive: Component
    {
        private readonly long _capacity;
        private bool _isAvailable { get; set; }

        public HardDrive(Mediator mediator, long capacity): base(mediator)
        {
            _capacity = capacity;
            _isAvailable = false;
        }

        public void WakeUp()
        {
            Console.WriteLine("Drive is available.");
            _isAvailable = true;
        }
        
        public void DoSomethingWithData()
        {
            if (_isAvailable)
            {
                Console.WriteLine("Doing something with data...");
                Thread.Sleep(500);
                Console.WriteLine("Done.");
            }
            else
            {
                Console.WriteLine("Drive is not available.");
            }
        }
    }
}