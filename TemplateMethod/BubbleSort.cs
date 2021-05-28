using System;

namespace ConsoleApp1.TemplateMethod
{
    public abstract class BubbleSort
    {
        public void Sort(ref int[] array)
        {
            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (Comparator(array[sort], array[sort + 1]))
                    {
                        var temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
        }

        public abstract bool Comparator(int x, int y);
    }
}