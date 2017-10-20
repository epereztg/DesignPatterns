namespace TaskManagerReport
{
    public interface IComponent
    {
        void Add(IComponent item);
        int Horas();
        void Accept(IVisitor visitor);
        void Display();
    }
}


