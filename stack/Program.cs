using System;
using System.Collections;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();

            myStack.Push(5);
            myStack.Push(10);
            myStack.Push(15);
            myStack.Push(20);

            myStack.PrintStack();

            myStack.Peek();

            Console.WriteLine("Item removido : {0}", myStack.Pop());

            myStack.PrintStack();

            Stack Stack = new Stack();
            Stack.Push("g");
            Stack.Push("f");
            Stack.Push("t");

            PrintValues(Stack);


        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
