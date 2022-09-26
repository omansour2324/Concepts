using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.Library.Datastructures.Basic
{
    public class SNode<T>
    {
        public T Value { get; set; }
        public SNode<T> Next { get; set; }
        public SNode(T value)
        {
            Value = value;
        }
    }

    public  class SLinkedList<T>
    {
        public SNode<T> Head;
        public int Length;

        public SLinkedList()
        {
            Length = 0;
            Head = null;
        }

        public void AddFirst(T value) 
        {
            var newElement = new SNode<T>(value);

            if (Head == null)
            {
                Head = newElement;
            }
            else
            {
                newElement.Next = Head;
                Head = newElement;
            }

            Length++;
        }
        public void AddLast(T value) 
        {
            var newElement = new SNode<T>(value);

            if (Head == null)
            {
                Head = newElement;
            }
            else
            {
                var current = Head;
                while(current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newElement;
            }

            Length++;
        }
        public int Find(T value) {

            int index = 0;
            var current = Head;

            while(current.Next != null && !current.Value.Equals(value))
            {
                current = current.Next;
                index++;
            }

            if (!current.Value.Equals(value))
                index = -1;

            return index;
        }
        
        public T Update(T oldValue, T newValue) 
        {
            var current = Head;
            while(current.Next != null && !current.Value.Equals(oldValue))
            {
                current = current.Next;
            }

            if (current.Value == null || !current.Value.Equals(oldValue))
                throw new Exception("Value Does Not Exist");

            current.Value = newValue;
            return current.Value;
        }


        public void Delete(T value)
        {
            if (Head == null)
            {
                return;
            }

            if(Head!= null)
            {
                var current = Head;
                SNode<T> previous = null;

                while(current.Next != null && !current.Value.Equals(value))
                {
                    previous = current;
                    current = current.Next;
                }

                if (current.Value == null || !current.Value.Equals(value))
                {
                    return;
                }
                else
                {
                    previous.Next = current.Next;
                    Length--;
                }
            }
        }

    }
}
