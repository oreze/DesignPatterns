using System;

namespace ConsoleApp1.TemplateMethod
{
    public class Program
    {
        public static void Main()
        {
            int[] array = {82, -22, 161, 1523, 1254, 357, 234, 12, 331, 23, 123, 1, 351, 745, 6};
            BubbleSort sort = new BubbleSortAscending();
            
            sort.Sort(ref array);
            
            foreach (var i in array)
            {
                Console.Write($"{i} ");
            }
        }
    }
}