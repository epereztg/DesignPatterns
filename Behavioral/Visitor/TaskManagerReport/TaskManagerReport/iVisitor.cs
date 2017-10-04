using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerReport
{
    public interface IVisitor
    {
        void Visit(JSONReport element);
        void Visit(TextReport element);
    }

}
