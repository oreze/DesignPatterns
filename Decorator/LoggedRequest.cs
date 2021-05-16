using System;

namespace ConsoleApp1.Decorator
{
    public class LoggedRequest: RequestDecorator
    {
        public LoggedRequest(Request request) : base(request)
        {
            RequestWrapper = request;
        }

        public override string SendRequest()
        {
            Console.WriteLine($"Sending request to {RequestWrapper.Address}, key = {RequestWrapper.SecretKey}. " +
                              $"Data: \n {RequestWrapper.Data}");
            Log();
            return "Body of the encrypted request";
        }

        private void Log()
        {
            Console.WriteLine("Log request to console");
        }
    }
}