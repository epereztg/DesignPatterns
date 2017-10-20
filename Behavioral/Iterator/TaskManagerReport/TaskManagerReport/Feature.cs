using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    public class Feature: IComponent, IVisitable
    {
        private List<IComponent> children = new List<IComponent>();
        public string team;
        public string name;
        public Feature(String team, string name)
        {
            this.team = team;
            this.name = name;
        }

        public IIterator CreateIterator()
        {
            return new TaskIterator(children);
        }

        public IComponent GetItem(int index)
        {
            if (index < children.Count)
            {
                return children[index];
            }
            else
            {
                return null;
            }
        }
        public List<IComponent> GetItems()
        {
            return children;
        }
        public bool RemoveItem(int index)
        {
            if (index < children.Count)
            {
                children.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
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
