using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    public class Feature: IComponent, IVisitable
    {
        private List<IComponent> _children = new List<IComponent>();
        public string team;
        public string name;
        public Feature(String team, string name)
        {
            this.team = team;
            this.name = name;
        }

        public IIterator CreateIterator()
        {
            return new TaskIterator(_children);
        }

        public IComponent GetItem(int index)
        {
            if (index < _children.Count)
            {
                return _children[index];
            }
            else
            {
                return null;
            }
        }
        public List<IComponent> GetItems()
        {
            return _children;
        }
        public bool RemoveItem(int index)
        {
            if (index < _children.Count)
            {
                _children.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
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
            Console.Write("{0}", team);
            Console.Write("|");
            //foreach (var component in this._children)
            //{
            //    component.Display();
            //}
            Console.WriteLine("{0}{1}", Horas(), "h");
        }
    }
}
