using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    static class MinStack
    {
        public static Stack<int> stack = new Stack<int>();
        public static Stack<int> minStack = new Stack<int>();
        public static void push(int x)
        {
            stack.Push(x);
            if (minStack.Count==0)
            {
                minStack.Push(x);
            }
            else if(minStack.Peek()>=x)
            {
                minStack.Push(x);
            }
        }

        public static int pop()
        {
            if (stack.Count==0)
            {
                return -1;
            }
            var x = stack.Pop();
            if (x==minStack.Peek())
            {
                minStack.Pop();
            }
            return x;
        }

        public static int top()
        {
            if (stack.Count==0)
            {
                return -1;
            }
            return stack.Peek();
        }

        public static int getMin()
        {
            if (minStack.Count==0)
            {
                return -1;
            }
            return minStack.Peek();
        }
    }
}
