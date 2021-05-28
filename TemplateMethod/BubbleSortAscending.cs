namespace ConsoleApp1.TemplateMethod
{
    public class BubbleSortAscending: BubbleSort
    {
        public override bool Comparator(int x, int y)
        {
            return x > y;
        }
    }
}