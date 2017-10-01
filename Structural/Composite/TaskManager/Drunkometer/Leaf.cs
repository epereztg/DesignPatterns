using System;

namespace Composite
{
    public class Leaf : IComponent
    {
        //// Constructor
        private int horas;
        public Leaf(int horas)
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