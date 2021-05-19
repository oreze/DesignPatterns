using System;
using System.Collections.Generic;

namespace ConsoleApp1.Composite
{
    public class Composite : Component
    {
        private List<Component> Components { get; }

        public Composite()
        {
            Components = new List<Component>();
        }

        public void Add(Component component)
        {
            Components.Add(component);
        }

        public void Add(params Component[] components)
        {
            foreach (var item in components)
                Components.Add(item);
        }

        public void Remove(Component component)
        {
            Components.Remove(component);
        }

        public void Pack()
        {
            foreach (var item in Components)
            {
                item.Pack();
            }
        }
    }
}