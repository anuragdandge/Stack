using System;

namespace AStack
{
    internal class Program
    {
        public static void Main(String[] args)
        {
           
            MyStack myStack = new MyStack();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.PrintStack();
            myStack.Peek();
            Console.WriteLine(" \n Item popped from Stack : {0}", myStack.Pop());
            myStack.PrintStack();

        }
    }
}

