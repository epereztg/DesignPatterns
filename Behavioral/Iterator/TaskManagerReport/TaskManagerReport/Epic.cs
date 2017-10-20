using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    public class Epic : IComponent, IVisitable
    {
        private readonly List<IComponent> children = new List<IComponent>();
        public double Budget;
        public string Name;
        public Epic(double budget, string name)
        {
            this.Budget = budget;
            this.Name = name;
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
