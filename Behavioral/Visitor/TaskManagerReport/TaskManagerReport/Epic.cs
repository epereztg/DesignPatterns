using System;
using System.Collections.Generic;

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
        public string Display()
        {
            //Display euro symbol
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            return "Estado del proyecto a xx / xx / xx \n"
                   + "======\n"
                   + this.name + " (Presupuesto " + this.budget + Convert.ToChar('€')  +")"+"\n"
                   + "======\n";            
        }     
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var component in this.children)
            {
                component.Accept(visitor);
            }
        }
    }
}
