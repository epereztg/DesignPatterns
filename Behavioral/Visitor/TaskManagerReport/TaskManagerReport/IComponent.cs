namespace TaskManagerReport
{
    public interface IComponent
    {
        void Add(IComponent item);
        int Horas();

        string Name();

        void Accept(IVisitor visitor);
    }
}


