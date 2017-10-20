using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    class TextReport : IVisitor
    {
        public void Generate(List<IVisitable> teamWork)
        {
            foreach (var element in teamWork)
            {
                element.Accept(this);
            }
        }

        internal void GenerateIterator(List<IVisitable> teamWork)
        {
            foreach (var element in teamWork)
            {
                IIterator iterator = element.CreateIterator();
                while (iterator.HasNext())
                {
                    IComponent item = (IComponent)iterator.Next();
                    //this.Generate(teamWork);

                    item.Display();
                    Console.WriteLine("");
                }
            }
        }

        public void Visit(Epic task)
        {
            DateTime localDate = DateTime.Now;

            //Display euro symbol
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var display = "Estado del proyecto a " + localDate + "\n"
                   + "======\n"
                   + task.Name + " (Presupuesto " + task.Budget + Convert.ToChar('€') + ")" + "\n"
                   + "======\n";
            Console.WriteLine("{0}", display);
        }

        public void Visit(Feature task)
        {
            var display = "\t" + task.name + '(' + task.team + ')';
            Console.WriteLine("{0}", display);
        }

        public void Visit(Us task)
        {
            var display = "\t \t" + task.Name + "(" + task.StoryPoints + ")";
            Console.WriteLine("{0}", display);
        }

        public void Visit(TeamTask task)
        {
            var display = " \t \t \t" + task.name + "(" + task.horas + ")";
            Console.WriteLine("{0}", display);
        }
    }
}
