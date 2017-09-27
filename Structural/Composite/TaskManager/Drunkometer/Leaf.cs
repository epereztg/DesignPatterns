using System;

namespace Composite
{
    public class Leaf : IComponent
    {

        // Constructor
        public Leaf(int horas)
        //   : base(horas)
        {
            Horas = horas;
        }

        private int _horas;
        public int Horas
        {
            get { return _horas; }
            set { _horas = value; }
        }

        public void Add(IComponent c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public int Display()
        {


            return Horas;
        }
    }
}