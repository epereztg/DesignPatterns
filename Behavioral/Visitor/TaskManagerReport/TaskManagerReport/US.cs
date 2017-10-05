﻿using System.Collections.Generic;
using TaskManagerReport;

namespace TaskManagerReport
{
    public class US : IComponent, IVisitable
    {
        private readonly List<IComponent> children = new List<IComponent>();
        private int storyPoints;
        private string name;

        public US(int storyPoints, string name)
        {
            this.storyPoints = storyPoints;
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

        public string Name()
        {
            return "\t\t"+this.name+"("+this.storyPoints+")";
        }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);

            foreach (var component in this.children)
            {
                visitor.Accept(component);

            }

        }
    }
}