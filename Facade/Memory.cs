using System;

namespace ConsoleApp1
{
    public class Memory
    {
        private byte[] MemoryMap { get; set; }

        public Memory()
        {
            MemoryMap = new byte[] {0x00, 0x22};
        }

        public byte GetFromMemory(int address)
        {
            return MemoryMap[address];
        }

        public bool SaveToMemory(byte value, int address)
        {
            if (address > MemoryMap.Length)
            {
                return false;
            }
            else
            {
                MemoryMap[address] = value;
                return true;
            }
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