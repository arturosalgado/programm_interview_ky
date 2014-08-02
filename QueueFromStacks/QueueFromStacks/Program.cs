using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFromStacks
{
    class Program
    {
       static void Main(string[] args)
       {
           MyQueue q = new MyQueue();
           q.enqueue(5);
           q.enqueue(3);
           q.enqueue(1);
           Console.WriteLine("{0}",q.dequeue());
           Console.WriteLine("{0}", q.dequeue()); 
           Console.WriteLine("{0}", q.dequeue());
           q.enqueue(10);
           q.enqueue(20);
           Console.WriteLine("{0}", q.dequeue());
           Console.WriteLine("{0}", q.dequeue());
           q.enqueue(3);
           q.enqueue(4);
           q.enqueue(5);
           q.enqueue(6);
           q.enqueue(7);
           Console.WriteLine("{0}", q.dequeue());
           Console.WriteLine("{0}", q.dequeue());
           Console.WriteLine("{0}", q.dequeue());
           Console.WriteLine("{0}", q.dequeue());
           Console.WriteLine("{0}", q.dequeue());
          // Console.WriteLine("{0}", q.dequeue()); underflow
           
           Console.ReadKey();
       }
    }

    class MyQueue { 
        
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        public void enqueue(int val)
        {
            stack1.Push(val);
        }
        public int dequeue()
        {
            shift();
            int val;
            val = stack2.Pop(); // underflow exception
            return val;
        }
        public void shift()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
        }

    }
}
