using System.Collections.Generic;

public interface IComponent
{
    //int Horas { get; set; }
    void Add(IComponent item);
    int Horas();

}
