using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueExerciseGenerics
{


    public class MyQueue<T>
    {
        private T[] _queueArray;

        public MyQueue()
        {
            _queueArray = new T[0];
        }

        public void Add(T item)
        {
            int maxIndex = _queueArray.Length + 1;
            T[] newArray = new T[maxIndex];
            _queueArray.CopyTo(newArray, 0);
            newArray[maxIndex-1] = item;
            _queueArray = newArray;
        }

        public T Remove()
        {
            T result = Peek();

            int maxIndex = _queueArray.Length - 1;
            T[] newArray = new T[maxIndex];

            for (int i = 1; i <= maxIndex; i++)
            {
                newArray[i - 1] = _queueArray[i];
            }

            _queueArray = newArray;

            return result;
        }

        public T Peek()
        {
            if (_queueArray.Length == 0)
            {
                throw new ArrayEmptyException("not found");
            }
            else
            {
                return _queueArray[0];
            }
        }

        

    }

}
