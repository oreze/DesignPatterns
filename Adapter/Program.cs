using System;

namespace ConsoleApp1.Adapter
{
    public class Program
    {
        public static void Main()
        {
            HttpService Service = new HttpService("https://guthib.com/");
            HttpServiceAdapter Adapter = new HttpServiceAdapter(Service);


            Console.WriteLine(Adapter.SendRequest("DataPickle"));
            Console.WriteLine(Adapter.SendRequest("DataJson"));
        }
    }
}