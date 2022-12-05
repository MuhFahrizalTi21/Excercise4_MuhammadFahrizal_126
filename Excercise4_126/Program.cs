using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise4_126
{
    class Stack
    {
        char [] Fahrizal = new char [42];

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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
