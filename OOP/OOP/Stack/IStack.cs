using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Stack
{
    interface IStack<T>
    {
        void Push(T t);
        T Pop();
    }
}
