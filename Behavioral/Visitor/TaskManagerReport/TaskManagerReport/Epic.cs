using System.Collections.Generic;
using TaskManagerReport;

namespace TaskManagerReport
{
    public class Epic : IComponent, IVisitable
    {
        private readonly List<IComponent> children = new List<IComponent>();
        private double budget;
        private string name;   
        public Epic(double budget, string name)
        {
            this.budget = budget;
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
            return this.name+" (Presupuesto "+ this.budget+"€)";
        }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);

            foreach (var component in this.children)
            {
                //component.Visit(visitor);
                visitor.Accept(component);

            }

        }
    }
}
