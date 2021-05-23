namespace ConsoleApp1.Adapter
{
    public interface Converter
    {
        public string ToJson(string pickle);
        public string ToPickle(string json);
    }
}