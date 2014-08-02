using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOfStacks
{
    class Program
    {
        static void Main(string[] args)
        {

            SetOfStacks s = new SetOfStacks();
            s.push(5);
            s.push(4);
            s.push(3);
            s.push(2);
            s.push(1);
            s.push(0);
            s.push(11);
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();

        }
    }

    class SetOfStacks {
        
        List<Stack<int>> stacks = new List<Stack<int>>();
        public bool isFull(Stack<int> s)
        {
            if (s.Count == 3)
                return true;
            return false;
        }
        public void push(int value)
        {
            Stack<int> last = getStack();
            if (last!= null && !isFull(last))
            {
                last.Push(value);
            }
            else {
                
                Stack<int> s = new Stack<int>(10);
                s.Push(value);
                stacks.Add(s);
            }

            int count = stacks.Count;

        }

        public int pop()
        {
            Stack<int> stack =getStack();
            

            int val =  stack.Pop();

            if (stack.Count == 0) {
                stacks.RemoveAt(stacks.Count-1);// or stacks.Remove();
            }
            int t = stacks.Count;
            return val;
           
        }

        public Stack<int> getStack()
        {
            if (stacks.Count == 0)
            {
                throw new Exception("Stack underflow");
            }
            else
              return stacks.ElementAt(stacks.Count-1);
        }
    
    }

}
