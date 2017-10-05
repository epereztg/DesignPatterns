using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite;

namespace TaskManagerReport
{
    class Report : IVisitor        
    {
        public void Accept(IComponent task)
        {
            Console.WriteLine("{0}", task.Name());
        }

    }
}
