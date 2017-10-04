using System.Collections.Generic;
using TaskManagerReport;

namespace TaskManagerReport
{
    public class Composite : IComponent, IVisitable
    {
        private readonly List<IComponent> children = new List<IComponent>();

        public Composite()
        {

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

        public void Visit(IVisitor visitor)
        {
            //visitor.Accept(this);

            foreach (var component in this.children)
            {
                visitor.Accept(component);

            }

        }
    }
}
