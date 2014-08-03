using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfTreeIsBinaryTree
{
    class Program
    {
        static int index = 0;
        public static int last_printed = Int32.MinValue;
        int t = 0;
        static void Main(string[] args)
        {
            int[] a = { 3, 15, 17, 20, 25, 30, 35 };
            Node<int> t = createTree(a, 0, a.Length - 1);
            print(t);
            Console.WriteLine("is tree BST? {0}", checkArray(t));


            Console.WriteLine("is tree BST? {0}", buildAndCheck(t));
            
            Console.ReadKey();
        }
        static void print(Node<int> t)
        {
            if (t == null) return;



            print(t.Left);
            Console.Write(" {0} ", t.Value);
            print(t.Right);

        }
        static Node<int> createTree(int[] a, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;
            Node<int> node = new Node<int>(a[mid]);
            node.Left = createTree(a, start, mid - 1);
            node.Right = createTree(a, mid + 1, end);

            return node;
        }

        static bool checkArray(Node<int> n)
        { 
            int []a = new int[7]; //cheating....
            buildArray(n, a);
            Console.Write(a);

            int ahead = 0;
            int behind = 0;
            for (int i = 1;  i< a.Length;i++ )
            {
                ahead = i;
                behind = i - 1;
                if (a[behind] > a[ahead]) return false;
            }

                Console.ReadKey();
            return true;
        }

        static void buildArray(Node<int> n, int []a )
        {
            if (n == null) return;

            buildArray(n.Left,a);
            a[index] = n.Value; index++;
            buildArray(n.Right, a);
        }


        static bool buildAndCheck(Node<int> n)
        {
            if (n == null) return true;

            if (!buildAndCheck(n.Left)) return false;
            if (last_printed > n.Value) return false;
            last_printed = n.Value;
            if (!buildAndCheck(n.Right)) return false;
          
            return true;
        }


    }
    class Node<T>
    {
        public Node<T> Left, Right;
        public T Value;
        public Node(T value)
        {
            this.Value = value;
        }
        public override string ToString()
        {
            return this.Value + "";
        }
    }
}
