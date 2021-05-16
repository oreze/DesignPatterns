using System;

namespace ConsoleApp1.Decorator
{
    public class Request: IRequestable
    {
        public string SecretKey { get; set; }
        public string Address { get; set; }
        public string Data { get; set; }

        public Request(string secretKey, string address, string data)
        {
            SecretKey = secretKey;
            Address = address;
            Data = data;
        }

        public string SendRequest()
        {
            Console.WriteLine($"Sending request to {Address}, key = {SecretKey}. Data: \n {Data}");
            return "Body of the request";
        }
    }
}