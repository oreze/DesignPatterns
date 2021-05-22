using System.Collections.Generic;

namespace ConsoleApp1.Proxy
{
    public class DbContext: Proxy
    {
        public HashSet<Description> Descriptions { get; set; }

        public DbContext()
        {
            Descriptions = new HashSet<Description>();
        }

        public string ExecuteQuery(string query)
        {
            return "Some data from database";
        }

        public void AddDescription(Description description)
        {
            Descriptions.Add(description);
        }
    }
}