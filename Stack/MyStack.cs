﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AStack
{
    internal class MyStack
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }
        public void Stack()
        {
            top = -1;
        }
        internal bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }
        internal int Pop()
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
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine(" \n Stack Underflow");
                return;
            }
            else
                Console.WriteLine("\n The topmost element of Stack is : {0}", stack[top]);
        }
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine(" \n Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine(" \n Items in the Stack are :\n ");
                Console.Write("[");
                for (int i = top; i > 0; i--)
                {
                    Console.Write(" "+stack[i]+" ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }




    }
}
