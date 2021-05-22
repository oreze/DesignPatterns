using System;

namespace ConsoleApp1.Proxy
{
    public class Program
    {
        public static void Main()
        {
            
            Description Description1 = new Description
            {
                ID = 0,
                Text = "Text of the description1"
            };
            Description Description2 = new Description
            {
                ID = 1,
                Text = "Text of the description2"
            };
            Description Description3 = new Description
            {
                ID = 2,
                Text = "Text of the description3"
            };
            

            DbContext Context = new DbContext();
            DbContextProxy ContextProxy = new DbContextProxy(Context);
            ContextProxy.AddDescription(Description1);
            ContextProxy.AddDescription(Description2);
            ContextProxy.AddDescription(Description3);
            ContextProxy.Authorize("123");
            Console.WriteLine(ContextProxy.HealthCheck());
            Console.WriteLine(ContextProxy.ExecuteQuery("some query"));
        }
    }
}