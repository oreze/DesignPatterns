namespace ConsoleApp1.Adapter
{
    public class HttpServiceAdapter: Converter
    {
        private HttpService Service { get; set; }

        public HttpServiceAdapter(HttpService service)
        {
            Service = service;
        }

        public string ToJson(string pickle)
        {
            return "DataJson";
        }
        
        public string ToPickle(string json)
        {
            return "DataPickle";
        }

        public string SendRequest(string data) 
        {
            if (data == "DataPickle")
                data = ToJson(data);

            return Service.SendRequest(data);

        }
    }
}