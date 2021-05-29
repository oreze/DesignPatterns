namespace ConsoleApp1.Mediator
{
    public interface Mediator
    {
        public void Notify(Component sender, string specificEvent);
    }
}