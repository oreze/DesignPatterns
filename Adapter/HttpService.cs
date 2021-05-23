using System;

namespace ConsoleApp1.Adapter
{
    public class HttpService
    {
        private string Address { get; set; }

        public HttpService(string address)
        {
            Address = address;
        }

        public string SendRequest(string json)
        {
            return "Request body";
        }
    }
}