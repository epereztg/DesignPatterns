namespace TaskManagerReport
{
    public interface IComponent
    {
        void Add(IComponent item);
        int Horas();

        string Name();
    }
}


