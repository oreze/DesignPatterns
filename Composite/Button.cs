using System;

namespace ConsoleApp1.Composite
{
    public class Button : Component

    {
        private int Column { get; set; }
        private int Row { get; set; }

        public Button(int column, int row)
        {
            Column = column;
            Row = row;
        }

        public void Pack()
        {
            Console.WriteLine($"Placed button in column {Column} and row {Row}");
        }
    }
}