using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite;

namespace TaskManagerReport
{
    public interface IVisitor
    {
        void Accept(IComponent task);
    }

}
