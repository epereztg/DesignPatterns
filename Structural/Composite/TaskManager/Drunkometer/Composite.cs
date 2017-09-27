using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : IComponent
    {
        private readonly List<IComponent> children = new List<IComponent>();

        public Composite()
        //   : base(horas)
        {
          
        }

        private int _horas;
        public int Horas
        {
            get { return _horas; }
            set { _horas = value; }
        }

        public void Add(IComponent component)
        {
            this.children.Add(component);
        }

     
        public int Display()
        {
          
            int horas = 0;
            foreach (var component in this.children)
            {
                //component.Display();
                //horas += component.Horas;
                horas += component.Display();


            }
            //Console.WriteLine(horas);
        }
    }
}