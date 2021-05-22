namespace ConsoleApp1.Proxy
{
    public class DbContextProxy : Proxy
    {
        private DbContext Context { get; set; }
        private bool Authorization { get; set; }

        public DbContextProxy(DbContext context)
        {
            Context = context;
        }

        public bool Authorize(string password)
        {
            if (password == "123")
                Authorization = true;
            return Authorization;
        }

        public bool HealthCheck()
        {
            return Context != null;
        }

        public string ExecuteQuery(string query)
        {
            if (Authorization && HealthCheck())
                return Context.ExecuteQuery(query);
            return "You are not authorized or database is not available";
        }

        public void AddDescription(Description description)
        {
            Context.AddDescription(description);
        }
    }
}