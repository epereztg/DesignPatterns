using System;

namespace TaskManagerReport
{
    public class TeamTask : IComponent, IVisitable
    {
        //// Constructor
        public int horas;
        public string name;
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

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}