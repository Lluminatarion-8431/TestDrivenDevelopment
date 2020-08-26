using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable where T : IComparable
    {
        //Member Variables
        private T[] _items;

        private int _capacity;
        private int _count;

        //Constructor
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        //Member Methods
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
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _items[i];
            }
        }
        public T this[int index]
        {
            get
            {
                if (index < _count && index >= 0)
                {
                    return _items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                _items[index] = value;
            }
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

        public void Remove(T item)
        {
            T[] tempArray = new T[_capacity];
            bool hasFound = false;
            for(int i = 0; i < _count; i++)
            {
                if(_items[i].Equals(item) && hasFound == false)
                {
                    hasFound = true;
                    _count--;
                }
                if (hasFound == true)
                {
                    tempArray[i] = _items[i];
                }
            }
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list = new CustomList<T>();

            for (int i = 0; i < list1._count; i++)
            {
                list.Add(list1[i]);
            }
            for (int i = 0; i < list2._count; i++)
            {
                list.Add(list2[i]);
            }
            return list;
        }
    }
}
