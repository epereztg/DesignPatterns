using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    public class Us : IComponent, IVisitable
    {
        private readonly List<IComponent> _children = new List<IComponent>();
        public int StoryPoints;
        public string Name;

        public Us(int storyPoints, string name)
        {
            this.StoryPoints = storyPoints;
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
            Console.WriteLine("{0}{1}", Horas(), "h");
            //Console.Write("|");
            //foreach (var component in this._children)
            //{
            //   component.Display();
            //}
        }
    }
}
