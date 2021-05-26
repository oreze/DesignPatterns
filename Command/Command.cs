namespace ConsoleApp1.Command
{
    public interface Command
    {
        public void Execute();
        public void Undo();
    }
}