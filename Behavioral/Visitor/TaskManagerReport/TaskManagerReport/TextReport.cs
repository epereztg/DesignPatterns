using System;

namespace TaskManagerReport
{
    class TextReport : IVisitor        
    {
        public void Visit(Epic task)
        {
            //Display euro symbol
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var display = "Estado del proyecto a xx / xx / xx \n"
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
