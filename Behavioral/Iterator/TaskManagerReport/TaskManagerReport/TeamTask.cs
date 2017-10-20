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
        public IIterator CreateIterator()
        {
            return new TaskIterator(null);
        }
        public void Add(IComponent c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public int Horas()
        {
            Display();
            return this.horas;//Should be void!

        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public void Display()
        {
           // Console.WriteLine("{0}{1}", horas, "h");
        }

    }
}