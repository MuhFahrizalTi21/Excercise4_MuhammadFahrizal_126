using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise4_126
{
    class Stack
    {
        Char [] Fahrizal = new Char [42];
        private int top;
        private int max;
        public Stack(int size)
        {
            top = -1;
        }
        bool empty()
        {
            if(top == -1)
                return true;
            else 
                return false;
        }
        public void Push(int element)
        {
            if (top == -1 )
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                Fahrizal[++top] = element;
            }
        }
        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Poped Elemen is: " + Fahrizal[top]);
                return;
            }
        }
        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Array [" + (i + 1) + "]: " + Fahrizal[i]);
                }
            }
        }
       
        static void Main(string[] args)
        {
        }
    }
}
    

