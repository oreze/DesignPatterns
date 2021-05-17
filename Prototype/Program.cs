using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            Banknote banknote = new Banknote(10m, "Some unique security at the back");
            Console.WriteLine($"Value = {banknote.Value}, security = {banknote.GetSecurity()}");
            Banknote clone = (Banknote) banknote.Clone();
            clone.SetSecurity("Some security");
            clone.Value = 2137m;
            Console.WriteLine($"Value = {clone.Value}, security = {clone.GetSecurity()}");
            Console.WriteLine($"Value = {banknote.Value}, security = {banknote.GetSecurity()}");
        }
    }
}