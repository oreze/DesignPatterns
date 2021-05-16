using System;

namespace ConsoleApp1.Decorator
{
    public class RequestDecorator: IRequestable
    {
        protected Request RequestWrapper { get; set; }

        public RequestDecorator(Request request)
        {
            RequestWrapper = request;
        }

        public virtual string SendRequest()
        {
            Console.WriteLine($"Sending request to {RequestWrapper.Address}, key = {RequestWrapper.SecretKey}. " +
                              $"Data: \n {RequestWrapper.Data}");
            return "Body of the request";
        }
    }
}