using System.Collections.Generic;
using System.Diagnostics.Tracing;
using ConsoleApp1.Observer.Interfaces;

namespace ConsoleApp1.Observer
{
    public class Div
    {
        private List<ClickListener> Listeners { get; set; }

        public Div() => Listeners = new List<ClickListener>();

        
        // In C# i cannot assing different classes that implements one interface to one list
        public void AddListener(ClickListener listener) => Listeners.Add(listener);

        public void RemoveListener(ClickListener listener) => Listeners.Remove(listener);

        public void NotifyObservers()
        {
            foreach (var item in Listeners)
            {
                item.Execute();
            }
        }
    }
}