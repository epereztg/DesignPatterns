using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    public class Feature : IComponent, IVisitable
    {
        private readonly List<IComponent> children = new List<IComponent>();
        private string team;
        private string name;
        public Feature(String team, string name)
        {
            this.team = team;
            this.name = name;
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
        public string Display()
        {
            return "\t" + this.name + '(' + this.team + ')';
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
