using System.Collections.Generic;

namespace TaskManagerReport
{
    public class US : IComponent, IVisitable
    {
        private readonly List<IComponent> children = new List<IComponent>();
        public int storyPoints;
        public string name;

        public US(int storyPoints, string name)
        {
            this.storyPoints = storyPoints;
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
