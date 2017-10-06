namespace TaskManagerReport
{
    public interface IVisitor
    {
        void Visit(Epic task);
        void Visit(Feature task);
        void Visit(US task);
        void Visit(TeamTask task);
    }

}
