using ConsoleApp1.Observer.Interfaces;

namespace ConsoleApp1.Observer
{
    public class Program
    {
        public static void Main()
        {
            ClickListener CustomListener1 = new ClickListener();
            ClickListener CustomListener2 = new ClickListener();
            Div Divider = new Div();
            Divider.AddListener(CustomListener1);
            Divider.AddListener(CustomListener2);
            Divider.NotifyObservers();
        }
    }
}