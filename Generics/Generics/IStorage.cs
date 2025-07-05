using System;
using System.Collections.Generic;

namespace Generics
{
    internal interface IStorage<T>
    {
        void Add(T item);
        T Get(int index);
        int Count { get; }
    }
}
