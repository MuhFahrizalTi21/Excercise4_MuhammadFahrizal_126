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
        public void Push(char element)
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
        public void Display()
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
            Stack S = new Stack ();
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("\n*****Stack Menu******\n");
                Console.WriteLine("1. Push ");
                Console.WriteLine("2. Pop ");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit ");
                Console.WriteLine("\nEnter your choice: ");
                string Input = Console.Readline();
                char ch = Convert.ToChar(Input == ""?"0": Input);
                switch(ch)
                {
                    case '1':
                        Console.WriteLine("\nEnter a number : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        S.Push(num);
                        break;
                    case '2':
                        if (S.empty())
                        {
                            Console.WriteLine("\nStack empty");
                            break;
                        }
                        S.Pop();
                        break;

                    case '3':
                        S.Display();
                        break;

                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }

        }
    }
}
    

