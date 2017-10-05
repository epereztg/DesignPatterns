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
        
        void Visit(IVisitor visitor);

        void Visit(Epic task);
        void Visit(Feature task);
        void Visit(US task);
        void Visit(TeamTask task);
    }

}
