using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.Library.Datastructures.Basic
{
    public class SArray<T>
    {
        private T[] _array;
        public SArray(int size)
        {
            _array = new T[size];
        }

        public void Add(T value)
        {
            for (int i = 0; i <= _array.Length - 1; i++)
            {
                if (_array[i].Equals(default(T)))
                {
                    _array[i] = value;
                    return;
                }
            }

            throw new Exception("Size Error: Array is full please increase the size of array");
        }

        public int Find(T value)
        {
            for (int i = 0; i <= _array.Length - 1; i++)
            {
                if (_array[i].Equals(value))
                    return i;
            }

            return -1;
        }

        public void Update(int index, T value)
        {
            _array[index] = value;
        }

        public void Delete(T value)
        {
            var index = Find(value);

            if (index <= -1)
                throw new Exception("Find Error: Value not found");

            //Shift Elements
            ShiftArray(index);

        }

        private void ShiftArray(int index)
        {
            for (int i = index; i <= _array.Length - 2; i++)
            {
                _array[i] = _array[i + 1];
            }
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("-----List------");
            foreach (var i in _array)
            {
                if (i.Equals(default(T)))
                    return;

                Console.Write($"{i} ");
            }
        }
    }
}
