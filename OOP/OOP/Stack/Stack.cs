using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Stack
{
    public class Stack<T>:IStack<T>
    {
        private const int MaxSize = 10;
        private T[] Storage = new T[MaxSize];
        private int Index = 0;

        public void Push(T t)
        {
            if (Index < MaxSize)
            {
               Storage[Index] = t;
               Index++;
            }
            else throw new Exception("Stack Overflow");
        }

        public T Pop()
        {

            if (Index > 0)
            {
                Index--;
                var v = Storage[Index];
                return v;
            }
            throw new Exception("Underflow");
        }
    }
}
