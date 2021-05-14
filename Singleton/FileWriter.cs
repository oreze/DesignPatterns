using System;

namespace ConsoleApp1.Singleton
{
    class FileWriter
    {
        private static FileWriter instance = null;

        private FileWriter()
        {
        }

        public static FileWriter GetInstance()
        {
            if (instance == null)
                instance = new FileWriter();
            return instance;
        }

        public void SaveToPath(string data, string path)
        {
            Console.WriteLine($"Data saved to {path}");
        }
    }
}