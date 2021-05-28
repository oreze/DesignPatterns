namespace ConsoleApp1.TemplateMethod
{
    public class BubbleSortDescending: BubbleSort
    {
        public override bool Comparator(int x, int y)
        {
            return x < y;
        }
    }
}