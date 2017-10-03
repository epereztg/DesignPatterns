using System;

namespace Composite
{
    public class Task : IComponent
    {
        //// Constructor
        private int horas;
        public Task(int horas)
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