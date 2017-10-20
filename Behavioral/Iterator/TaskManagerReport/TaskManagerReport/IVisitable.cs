namespace TaskManagerReport
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
        IIterator CreateIterator();
    }
}
