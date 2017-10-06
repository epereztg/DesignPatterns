using System;

namespace TaskManagerReport
{
    class JSONReport : IVisitor
    {
        //public void Visit(IVisitor visitor)
        //{
        //    //foreach (var component in visitor.children)
        //    //{
        //    //    Console.WriteLine("{0}", visitor.Display());
        //    //}
        //}

        public void Visit(Epic epic)
        {
            //Console.WriteLine("{0}", epic.Display());
            var display = "{type: epic,description: epic.name,features: [";
            Console.WriteLine("{0}", display);
        }

        public void Visit(Feature task)
        {
            var display = "{type: epic,description: epic.name,features: [";
            Console.WriteLine("{0}", display);
        }

        public void Visit(US task)
        {
            var display = "{type: epic,description: epic.name,features: [";
            Console.WriteLine("{0}", display);
        }

        public void Visit(TeamTask task)
        {
            var display = "{type: epic,description: epic.name,features: [";
            Console.WriteLine("{0}", display);
        }
    }
}
