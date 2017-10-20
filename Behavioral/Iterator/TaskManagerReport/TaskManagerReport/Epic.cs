using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    public class Epic : IComponent, IVisitable
    {
        private readonly List<IComponent> _children = new List<IComponent>();
        public double Budget;
        public string Name;
        public Epic(double budget, string name)
        {
            this.Budget = budget;
            this.Name = name;
        }
        public IIterator CreateIterator()
        {
            return new TaskIterator(_children);
        }
        public void Add(IComponent component)
        {
            this._children.Add(component);
        }

        public int Horas()
        {
            int horas = 0;
            foreach (var component in this._children)
            {
                horas += component.Horas();
            }
            return horas;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var component in this._children)
            {
                component.Accept(visitor);
            }
        }

        public void Display()
        {
            Console.Write("{0}", Name);
            foreach (var component in this._children)
            {
                component.Display();
            }
        }
        public void DisplayName()
        {
            Console.Write("{0}", Name);          
        }

    }
}
