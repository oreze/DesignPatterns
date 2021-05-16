using System;

namespace ConsoleApp1.Decorator
{
    public class EncryptedRequest: RequestDecorator
    {
        public EncryptedRequest(Request request) : base(request)
        {
            RequestWrapper = request;
        }

        public override string SendRequest()
        {
            Console.WriteLine($"Data has been encrypted. Body: {Encrypt()}");
            Console.WriteLine($"Sending request to {RequestWrapper.Address}, key = {RequestWrapper.SecretKey}. " +
                              $"Data: \n {RequestWrapper.Data}");
            return "Encrypted request response";
        }

        private string Encrypt()
        {
            return "Encrypted request";
        }
    }
}