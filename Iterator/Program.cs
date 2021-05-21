using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp1.Iterator
{
    public class Program
    {
        public static void Main()
        {
            Kolokwium Kolos1 = new Kolokwium("UML");
            Kolokwium Kolos2 = new Kolokwium("Jakiś durny referat");
            Kolokwium Kolos3 = new Kolokwium("Gigant co ostatecznie nas pogrąży");
            List<Kolokwium> Kolosy = new List<Kolokwium>();
            Kolosy.Add(Kolos1);
            Kolosy.Add(Kolos2);
            Kolosy.Add(Kolos3);
            
            KolokwiaIterator Iterator = new KolokwiaIterator(Kolosy);
            while (Iterator.HasNext())
            {
                Console.WriteLine(Iterator.Next().Subject);
            }
        }
    }
}