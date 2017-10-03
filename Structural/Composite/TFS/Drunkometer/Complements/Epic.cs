using System.Collections.Generic;

namespace CoffeeShop.Complements
{
    public class Epic : IComponent
    {
        private List<IComponent> _subTasks = new List<IComponent>();

        public Epic(int time)

        {
            this.Time = time;
        }

        public int Time { get; set; }        

        public void AddTask(IComponent task)
        {
            _subTasks.Add(task);
        }
        public List<IComponent> Items
        {
            get
            {
                return new List<IComponent>(_subTasks);
            }
        }

        public int Horas()
        {
            return Time;
        }
    }
}