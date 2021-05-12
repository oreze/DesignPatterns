using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class CPU: Computable
    {
        private Queue<byte> _instructions { get; }

        public CPU()
        {
            _instructions = new Queue<byte>();
            Console.WriteLine("Starting CPU");
            _instructions.Enqueue(0x22);
        }

        public string GetResult(byte[] instructions)
        {
            foreach (byte value in instructions)
            {
                _instructions.Enqueue(value);
            }

            Console.WriteLine("CPU is engaged...");

            for (int i = 0; i < _instructions.Count; i++)
            {
                _instructions.Dequeue();
            }

            return "result";
        }

        private void Crash()
        {
            Console.WriteLine("Cpu crashed");
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
                              "przepraszam bardzo i pozdrawiam cieplutko");
            return new byte[] {0x11, 0x22};
        }
    }
}