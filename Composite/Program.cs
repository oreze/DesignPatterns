using System;

namespace ConsoleApp1.Composite
{
    public class Program
    {
        public static void Main()
        {
            Composite Composite = new Composite();

            Button Create = new Button(0, 0);
            Button Read = new Button(0, 1);
            Button Update = new Button(1, 0);
            Button Delete = new Button(1, 1);
            
            Composite.Add(Create, Read, Update, Delete);
            Composite.Pack();
        }
    }
}