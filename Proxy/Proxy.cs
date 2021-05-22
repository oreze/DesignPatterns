namespace ConsoleApp1.Proxy
{
    public interface Proxy
    {
        public string ExecuteQuery(string query);
        public void AddDescription(Description description);
    }
}