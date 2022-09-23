using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Add() {}
        public T Find() { return default; }
        public void Delete() { }
        public void Update() { }

    }
}
