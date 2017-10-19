using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    public class Epic : IComponent, IVisitable
    {
        private readonly List<IComponent> children = new List<IComponent>();
        public double budget;
        public string name;
        public Epic(double budget, string name)
        {
            this.budget = budget;
            this.name = name;
        }
        public IIterator CreateIterator()
        {
            return new TaskIterator(children);
        }
        public void Add(IComponent component)
        {
            this.children.Add(component);
        }

        public int Horas()
        {
            int horas = 0;
            foreach (var component in this.children)
            {
                horas += component.Horas();
            }
            return horas;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var component in this.children)
            {
                component.Accept(visitor);
            }
        }

    }
}
