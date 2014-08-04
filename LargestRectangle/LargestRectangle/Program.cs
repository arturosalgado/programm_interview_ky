using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestRectangle
{
    class Program
    {
        static int Largest(int[] histos)
        {
            Stack<int> heights = new Stack<int>();
            Stack<int> indexes = new Stack<int>();
            int largestSize = 0;
            for (int i = 0; i < histos.Length; i++)
            {
                if (heights.Count == 0 || histos[i] > heights.Peek())
                {
                    heights.Push(histos[i]);
                    indexes.Push(i);

                }
                else if (histos[i] < heights.Peek())
                {
                    int lastIndex = 0;
                    while (heights.Count != 0 && histos[i] < heights.Peek())
                    {
                        lastIndex = indexes.Pop();
                        int tempArea = heights.Pop() * (i - lastIndex);
                        if (largestSize < tempArea)
                        {
                            largestSize = tempArea;
                        }
                    }
                    heights.Push(histos[i]);
                    indexes.Push(lastIndex);

                }
            }

            while (heights.Count > 0)
            {
                int tempArea = heights.Pop() * (histos.Length - indexes.Pop());
                if (largestSize < tempArea)
                {
                    largestSize = tempArea;
                }
            }

         
            return largestSize;

        }
        static void Main(string[] args)
        {

            int[] histogram = { 2, 4, 2, 1 };

            Console.Write("Largest {0}", Largest(histogram));
            
        }
    }
}
