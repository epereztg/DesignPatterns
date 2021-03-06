﻿using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : IComponent
    {
        private readonly List<IComponent> children = new List<IComponent>();

        public Composite()
        {
          
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
    }
}