namespace TaskManagerReport
{
    public interface IIterator
    {
        object Next();
        //object Prev();
        bool HasNext();
        //void Reset();
    }
}
