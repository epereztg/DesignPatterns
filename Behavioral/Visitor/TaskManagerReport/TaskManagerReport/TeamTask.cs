using System;
using TaskManagerReport;

namespace Composite
{
    public class TeamTask : IComponent, IVisitable
    {
        //// Constructor
        private int horas;
        private string name;
        public TeamTask(int horas, string name)
        {
            this.horas = horas;
            this.name = name;
        }

        public void Add(IComponent c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public int Horas()
        {
            return this.horas;
        }
        public string Name()
        {
            return "*"+this.name+"("+this.horas+")";                
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}