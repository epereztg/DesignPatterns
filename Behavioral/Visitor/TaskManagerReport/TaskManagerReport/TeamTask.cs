using System;
using TaskManagerReport;

namespace Composite
{
    public class TeamTask : IComponent
    {
        //// Constructor
        private int horas;
        public TeamTask(int horas)
        {
            this.horas = horas;
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