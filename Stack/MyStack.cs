﻿using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace AStack
{



    class MyStack

    {
        
        static readonly int MAX = 5;
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
                Console.WriteLine("Stack Overflow ( From Push )");
                return false;
            }
            else
            {
                try
                {
                    stack[++top] = data;
                }
                catch (Exception error)
                {
                    Console.WriteLine("\n ERR !!! : " + error.Message + "\n");
                }
                return true;
            }
        }
        internal int Pop()
        {
            if (top <= 0)
            {
                Console.WriteLine("Stack Underflow ( From Pop )");
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
            if (top <= 0)
            {
                Console.WriteLine(" \n Stack Underflow");
                return;
            }
            else
            {
                try
                {
                    Console.WriteLine("\n The topmost element of Stack is : {0}", stack[top]);

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }



        internal void PrintStack()
        {
            if (top <= 0)
            {
                 Console.WriteLine(" \n Stack Underflow (From PrintStack)");
            }
            else
            {
                try
                {
                    for (int i = top; i > 0; i--)
                    {
                        Console.Write(" " + stack[i] + " ");
                    }
                }
                catch (StackException error)
                {

                    throw error;
                    Console.WriteLine("\n ERR !!! : " + error.Message + "\n");
                }


                Console.WriteLine();
            }
        }

        
    }

     class StackException : Exception
    {
        
        public  StackException(string str) {
            Console.WriteLine(str);
        } 
        
    }

   


}
