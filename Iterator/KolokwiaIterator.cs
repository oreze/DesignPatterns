using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp1.Iterator
{
    public class KolokwiaIterator: Iterator
    {
        private int Position { get; set; } = -1;
        private List<Kolokwium> Kolokwia { get; }

        public KolokwiaIterator(List<Kolokwium> kolokwia)
        {
            Kolokwia = kolokwia;
        }


        public Kolokwium Next()
        {
            Position += 1;
            return Kolokwia[Position];
        }

        public bool HasNext()
        {
            return Position != Kolokwia.Count - 1;
        }
    }
}