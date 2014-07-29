using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeStacksSingleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeStacks s = new ThreeStacks();
            s.push(0,10);
            s.push(2,20);
            s.push(2,20);
            s.pop(2);
            s.pop(1);
        }
    }
    class ThreeStacks
    { 
        static int stackSize = 10;
        int[] array = new int[stackSize * 3];

        int[] pointer = { -1,-1,-1};

        public void push(int stack, int value) 
        {
            if (pointer[stack] + 1 >= stackSize)
            {
                throw new Exception("out of space");
            }
            pointer[stack]++;
            array[calculateAddress(stack)] = value;
        }
        public int pop(int stack)
        {
            if (pointer[stack] == -1) throw new Exception("underflow ");



            int ret =  array[calculateAddress(stack)];
            array[calculateAddress(stack)] = 0;//clear it 
            pointer[stack]--;
            return ret;
        }
        int calculateAddress(int stack)
        { 
            int adress =  stack * stackSize + pointer[stack];
            adress = adress + 0;
            return adress;

        }

    
    }

}
