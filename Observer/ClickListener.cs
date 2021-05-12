using System;
using System.Diagnostics.Tracing;

namespace ConsoleApp1.Observer
{
    public class ClickListener: EventListener
    {
        public void Execute()
        {
            RunScript();
        }

        private void RunScript()
        {
            Console.WriteLine("Script running");
        }
    }
}