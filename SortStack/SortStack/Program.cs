using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> mystack = new Stack<int>();
            mystack.Push(5);
            mystack.Push(9);
            mystack.Push(3);
            mystack.Push(1);

            Stack<int> sorted = sort(mystack);

            sorted.Peek();

            Console.ReadKey();

        }

        static Stack<int> sort(Stack<int> stack)
        {
            Stack<int> buffer = new Stack<int>();
            while (stack.Count > 0)
            {
                int temp = stack.Pop();
                while (buffer.Count > 0 && buffer.Peek() > temp)
                {
                    stack.Push(buffer.Pop());
                }
                buffer.Push(temp);
            }
            return buffer;
        }

    }
}
