using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    class TaskIterator : IIterator
    {
        private readonly List<IComponent> _itemsList = new List<IComponent>();
        //public string team;
        //public string name;
        private int position = 0;

        public TaskIterator(List<IComponent> itemsList)
        {
            _itemsList = itemsList;
        }

        public bool HasNext()
        {
            if (position < _itemsList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Next()
        {
            IComponent itemContents = _itemsList[position];
            position++;
            return itemContents;
        }
    }
}
