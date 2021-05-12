using System;

namespace ConsoleApp1
{
    public class SSD: Communicable
    {
        private Memory _memory { get; }

        public SSD(Memory memory)
        {
            _memory = memory;
        }
        public string GetFromMemory(int address)
        {
            return _memory.GetFromMemory(address).ToString();
        }

        public bool SendData(byte[] data)
        {
            if (data.Length > 0)
                Console.WriteLine($"Send data with header {data[0]}");
            else
                return false;
            return true;
        }

        public byte[] ReceiveData()
        {
            Console.WriteLine("tu powinien coś robić ale mi się już nie chce, jest 23 a ja jutro jade do Lublina," +
                              "przepraszam");
            return new byte[] {0x11, 0x22};
        }
    }
}