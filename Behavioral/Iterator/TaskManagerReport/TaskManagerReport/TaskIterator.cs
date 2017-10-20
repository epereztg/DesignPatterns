using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    class TaskIterator : IIterator
    {
        private readonly List<IComponent> _itemsList = new List<IComponent>();
        private int _position = 0;

        public TaskIterator(List<IComponent> itemsList)
        {
            _itemsList = itemsList;
        }

        public bool HasNext()
        {
            if (_position < _itemsList.Count)
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
            IComponent itemContents = _itemsList[_position];
            _position++;
            return itemContents;
        }
    }
}
