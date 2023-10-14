using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyStackExerciseGenerics
{
    public class MyStack<T>
    {
        private T[] _items;

        public MyStack()
        {
            _items = new T[0];
        }

        public void Add(T item)
        {
            int intLength = _items.Length + 1;
            T[] newItems = new T[intLength];
            _items.CopyTo(newItems, 0);
            newItems[intLength - 1] = item;
            _items = newItems;
        }

        public T Remove()
        {
            T result;

            result = Peek();

            T[] newItems = new T[_items.Length - 1];

            for (int i = 0; i < _items.Length - 1; i++)
            {
                newItems[i] = _items[i];
            }

            _items = newItems;

            return result;
        }

        public T Peek()
        {
            if (_items.Length == 0)
            {
                throw new InvalidOperationException("ERROR");
            }

            return _items[_items.Length - 1];
        }

    }

}
