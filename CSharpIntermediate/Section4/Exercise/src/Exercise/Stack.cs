using System;
using System.Collections;

namespace Exercise
{
    public class Stack
    {
        public Stack()
        {
            StackHolder = new ArrayList();
        }

        public ArrayList StackHolder { get; set; }

        public void Push(object obj)
        {
            StackHolder.Add(obj);
        }

        public object Pop()
        {
            if (StackHolder == null) throw new InvalidOperationException();
            var obj = StackHolder[StackHolder.Count - 1];
            StackHolder.Remove(obj);
            return obj;
        }

        public void Clear()
        {
            StackHolder.Clear();
        }
    }
}