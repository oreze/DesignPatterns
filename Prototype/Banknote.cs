using System;

namespace ConsoleApp1
{
    public class Banknote: Prototype
    {
        public decimal Value { get; set; }
        private string Security { get; set; }

        public Banknote(decimal value, string security)
        {
            Value = value;
            Security = security;
        }

        public string GetSecurity()
        {
            return Security;
        }  
        public void SetSecurity(string security)
        {
            Security = security;
        }

        public Prototype Clone()
        {
            Banknote clone = (Banknote) this.MemberwiseClone();
            Console.WriteLine($"Clone Value = {clone.Value}, security = {clone.Security}");
            return clone;
        }
    }
}