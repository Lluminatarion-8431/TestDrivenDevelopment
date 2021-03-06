﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable where T : IComparable
    {
        //Member Variables (Has a)
        private T[] _items;

        private int _capacity;
        private int _count;
        
        //Constructor (Spawner)
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        //Member Methods (Can Do)
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _items[i];
            }
        }
        //A read-only count property/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int Count
        {
            get
            {
                return _count;
            }
        }
        //Capacity Property//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
        
        //C# Indexer with out-of-bounds index////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
        //Add Method/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
        //Remove Method//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
        //Overloading +Operator//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
        //Overloading -Operator//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list = new CustomList<T>();
            list = list1 + list2;

            for (int i = 0; i < list1._count; i++)
            {
                list.Remove(list2[i]);
            }
            return list;
        }
        //ToString() method//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public override string ToString()
        {
            string value = "";
            for (int i = 0; i < _count; i++)
            {
                value += _items[i].ToString();
            }
            return value;
        }
        //Zipping two list classes///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static CustomList<T> Zip(CustomList<T> odd, CustomList<T> even)
        {
            int i = 0;
            CustomList<T> zipList = new CustomList<T>();

            do
            {
                if (i + 1 <= odd._count)
                {
                    zipList.Add(odd[i]);
                }
                if (i + 1 <= even._count)
                {
                    zipList.Add(even[i]);
                }
                i++;
            }
            while ((i + 1 <= odd._count) || (i + 1 <= even._count));

            return zipList;
        }
        //Sorting Algorithm: Bubble Sort/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public CustomList<T> Sort()
        {
            int i;
            int j;

            for (j = _count - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (_items[i].CompareTo(_items[i + 1]) > 0)
                    {
                        exchange(this, i, i + 1);
                    }
                }
            }
            return this;
        }
        public void exchange(CustomList<T> l1, int m, int n)
        {
            T temporary;
            temporary = l1[m];
            l1[m] = l1[n];
            l1[n] = temporary;
        }
    }
}
