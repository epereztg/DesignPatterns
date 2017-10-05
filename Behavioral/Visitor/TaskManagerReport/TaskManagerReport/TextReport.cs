using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite;

namespace TaskManagerReport
{
    class TextReport : IVisitor        
    {
        public void Visit(IVisitor visitor)
        {
            //foreach (var component in visitor.children)
            //{
            //    Console.WriteLine("{0}", visitor.Name());
            //}
        }

        public void Visit(Epic epic)
        {
            Console.WriteLine("{0}", epic.Name());
        }

        public void Visit(Feature task)
        {
            Console.WriteLine("{0}", task.Name() );
        }

        public void Visit(US task)
        {
            Console.WriteLine("{0}", task.Name() );
        }

        public void Visit(TeamTask task)
        {
            Console.WriteLine("{0}", task.Name());
        }
    }
}
