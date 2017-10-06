using System;

namespace TaskManagerReport
{
    class JSONReport : IVisitor
    {
        public void Visit(IVisitor visitor)
        {
            //foreach (var component in visitor.children)
            //{
            //    Console.WriteLine("{0}", visitor.Display());
            //}
        }

        public void Visit(Epic epic)
        {
            Console.WriteLine("{0}", epic.Display());
        }

        public void Visit(Feature task)
        {
            Console.WriteLine("{0}", task.Display());
        }

        public void Visit(US task)
        {
            Console.WriteLine("{0}", task.Display());
        }

        public void Visit(TeamTask task)
        {
            Console.WriteLine("{0}", task.Display());
        }
    }
}
