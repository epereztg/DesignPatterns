using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    class TextReport : IVisitor        
    {
        internal void GenerateIterator(List<IComponent> teamWork)
        {
            foreach (var element in teamWork)
            {
                IIterator iterator = element.CreateIterator();
                while (iterator.HasNext())
                {
                    IComponent item = (IComponent)iterator.Next();
                    Console.WriteLine(item);
                    //Console.WriteLine(item.Horas());
                    //this.Generate(iterator);
                }
            }
        }

        public void Generate(List<IVisitable> teamWork)
        {
            foreach (var element in teamWork)
            {
                element.Accept(this);
            }
        }

        public void Visit(Epic task)
        {
            DateTime localDate = DateTime.Now;

            //Display euro symbol
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var display = "Estado del proyecto a "+ localDate + "\n"
                   + "======\n"
                   + task.name + " (Presupuesto " + task.budget + Convert.ToChar('€') + ")" + "\n"
                   + "======\n";
            Console.WriteLine("{0}", display);
        }

        public void Visit(Feature task)
        {            
            var display = "\t" + task.name + '(' + task.team + ')';
            Console.WriteLine("{0}", display);
        }

        public void Visit(US task)
        {            
            var display = "\t \t" + task.name + "(" + task.storyPoints + ")";
            Console.WriteLine("{0}", display);
        }

        public void Visit(TeamTask task)
        {            
            var display = " \t \t \t" + task.name + "(" + task.horas + ")";
            Console.WriteLine("{0}", display);
        }
    }
}
