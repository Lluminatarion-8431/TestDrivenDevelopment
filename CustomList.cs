using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        T[] _items;

        int _capacity;
        int _count;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }


        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        public void Add(T item)
        {

            if (_count == _capacity)
            {
                Capacity = _capacity * 2;
                T[] tempArray = new T[_capacity];
                for (int i = 0; i < _count; i++)
                {
                    tempArray[i] = _items[i];
                }
                _items = tempArray;
            }
            _items[_count] = item;
            _count++;
        }
    }
}
