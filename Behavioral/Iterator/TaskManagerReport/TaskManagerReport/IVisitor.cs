using System.Collections.Generic;

namespace TaskManagerReport
{
    public interface IVisitor
    {
        void Visit(Epic task);
        void Visit(Feature task);
        void Visit(Us task);
        void Visit(TeamTask task);

        void Generate(List<IVisitable> teamWork);
    }

}
