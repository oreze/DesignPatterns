using System;

namespace ConsoleApp1.Mediator
{
    public class HardwareInfo: Mediator
    {
        public Processor Processor { get; set; }
        public HardDrive HardDrive { get; set; }

        public void Notify(Component sender, string specificEvent)
        {
            if (sender is Processor)
            {
                switch (specificEvent)
                {
                    case "drive_start":
                        HardDrive.WakeUp();
                        break;
                    case "drive_doSomething":
                        HardDrive.DoSomethingWithData();
                        break;
                }
            }
        }
    }
    
}