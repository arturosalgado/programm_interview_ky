using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTheTreeBalanced
{
    class Program
    {
        static void Main(string[] args)
        {

            Node t = getTree();
            Console.WriteLine("Is balanced {0}",isBalanced(t));
            Console.WriteLine("Is balanced Improved {0}", isBalancedImproved(t));

            Console.ReadKey();
        }

        static bool isBalanced(Node t)
        {
            if (t == null) return true;
            int height = getHeight(t.right) - getHeight(t.left);
            if (Math.Abs(height) > 1)
            {
                return false;
            }
            return isBalanced(t.left) && isBalanced(t.right);

        }
        static int getHeight(Node t)
        {
            if (t == null) return 0;

            int l = getHeight(t.left);
            int r = getHeight(t.right);
            Console.WriteLine("left {0}",l);
            Console.WriteLine("right {0}",r);
            return Math.Max(r,l)+1;

        }

        static bool isBalancedImproved(Node n)
        {
            if (getHeight2(n) == -1)
                return false;
            return true;
        }

        static int getHeight2(Node n)
        {
             if (n == null) return 0;

             int left = getHeight2(n.left);
             if (left ==-1) return -1;

             int right = getHeight2(n.right);
             if (right == -1) return -1;

             if (Math.Abs(right - left) > 1)
                 return -1;
             else
                return Math.Max(left,right) + 1;


        }


        static Node getTree()
        {
            Node r = new Node(5);
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);
            Node n8 = new Node(8);


            r.left = n1;
            r.right = n2;
            n2.left = n3;
            n3.left = n4;
            n4.right = n5;
            n5.right = n6;
            n6.right = n7;
            n7.right = n8;

            return r;

        }
    }

    class Node {
        public int value;
        public Node right;
        public Node left;
        public Node(int value)
        {
            this.value = value;
        }

    
    }

}
