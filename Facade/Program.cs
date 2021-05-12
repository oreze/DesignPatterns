using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            CPU cpu = new CPU();
            Memory memory = new Memory();
            Memory memorySSD = new Memory();
            SSD ssd = new SSD(memorySSD);
            Motherboard motherboard = new Motherboard(memory, cpu, ssd);
            UserInterface userInterface = new UserInterface(motherboard);
            userInterface.Click();


            // Console.WriteLine(string.Compare(new string("silent".OrderBy(x => x).ToArray()), new string("listen".OrderBy(x => x).ToArray())) == 0 ? true : false);
        }
    }
}