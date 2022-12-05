using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise4_126
{
    class Stack
    {
        int [] Fahrizal = new int [42];

        int top;
        public Stack()
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
                return -1;
            }
            else
            {
                Console.WriteLine("Poped Elemen is: " + Fahrizal[top]);
                return Fahrizal[top--];
            }
        }
        public void display()
        {
            
        }
       
        static void Main(string[] args)
        {
        }
    }
}
    

