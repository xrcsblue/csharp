using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.Stack;

namespace OOPTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void PushPutsTheValueInStack()
        {
            var stack = new Stack<int>();
            var valIn = 222;
            stack.Push(valIn);
            var valOut = stack.Pop();
            Assert.AreEqual(valIn, valOut);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PushingBeyondLimitThrowsException()
       { 
            var stack = new Stack<int>();
            for (int i = 0; i < 11; i++)
                stack.Push(i);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PoppingBeyondLimitThrowsException()
        {
            var stack = new Stack<int>();
            stack.Pop();
        }

    }
}
