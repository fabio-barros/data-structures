using System;

namespace stack
{
    public class MyStack
    {
        static readonly int MAX_SIZE = 100;
        int top;
        int[] stack = new int[MAX_SIZE];


        public MyStack()
        {
            top = -1;
        }

        public bool Push(int value)
        {
            if (top >= MAX_SIZE)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = value;
                return true;
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("Elemento no topo : {0}", stack[top]);
        }

        bool IsEmpty()
        {
            return (top < 0);
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Elementos no stacj :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }

}
