using System;

namespace TaskManagerReport
{
    public class TeamTask : IComponent
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
            return this.horas;
        }

  
    }
}