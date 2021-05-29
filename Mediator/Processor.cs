using System;
using System.Threading;

namespace ConsoleApp1.Mediator
{
    public class Processor: Component
    {

        public Processor(Mediator mediator) : base(mediator)
        {
            
        }
        public void Compute()
        {
            Console.WriteLine("Computing something...");
            _mediator.Notify(this, "drive_start");
            _mediator.Notify(this, "drive_doSomething");
            _mediator.Notify(this, "computed");
            Thread.Sleep(500);
            Console.WriteLine("Something computed.");
        }
    }
}