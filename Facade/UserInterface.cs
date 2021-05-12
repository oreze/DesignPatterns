using System;

namespace ConsoleApp1
{
    public class UserInterface
    {
        private Motherboard Motherboard { get; set; }
        public UserInterface(Motherboard motherboard)
        {
            Motherboard = motherboard;
        }

        public void Click()
        {
            Console.WriteLine("User has clicked");
            var random = new Random();
            Motherboard.ParseInputToInstructions("click", 1);
        }
    }
}