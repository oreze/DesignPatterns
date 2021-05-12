using System;

namespace ConsoleApp1
{
    public class Motherboard
    {
        private Memory _memory { get; set; }
        private CPU _cpu { get; set; }
        private SSD _ssd { get; set; }

        public Motherboard(Memory ram, CPU cpu, SSD ssd)
        {
            _memory = ram;
            _cpu = cpu;
            _ssd = ssd;
        }

        public string ParseInputToInstructions(string instructions, int address)
        {
            Console.WriteLine($"Parsing input {instructions} for address {address}");
            if (address == 1)
                return _memory.GetFromMemory(0).ToString();
            else if (address == 2)
                return _cpu.GetResult(new byte[] {0x00, 0x11, 0x22}).ToString();
            else if (address == 3)
                return _ssd.GetFromMemory(0).ToString();
            else
                Console.WriteLine("Wrong input");
            return "";
        }
    }
}