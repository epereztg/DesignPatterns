using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerReport;

namespace TaskManagerReport
{
    public interface IVisitable
    {
        void Visit(IVisitor visitor);
    }
}
