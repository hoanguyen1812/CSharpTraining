using System;

namespace Generics
{
    public class GenericList<T>
    {
        public T this[int index] => throw new NotImplementedException();

        public void Add(T value)
        {
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
}