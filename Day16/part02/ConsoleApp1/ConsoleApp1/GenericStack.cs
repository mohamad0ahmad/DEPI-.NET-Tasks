using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class GenericStack<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item) => items.Add(item);

        public T Pop()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            T value = items[^1];
            items.RemoveAt(items.Count - 1);
            return value;
        }

        public T Peek()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            return items[^1];
        }

        public int Count => items.Count;
    }
}
