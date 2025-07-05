using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    internal class ListStorage<T> : IStorage<T>
    {
        private readonly List<T> _elements = [];

        public int Count
        {
            get { return _elements.Count; }
        }

        public void Add(T item)
        {
            _elements.Add(item);
        }

        public T Get(int index)
        {
            return _elements[index];
        }

        public void GetAllElements()
        {
            foreach (var element in _elements) 
            {
                Console.Write(element + " ");
            }
        }
    }
}
