using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*print a full binary tree boundary arturodelosangeles.com */
namespace TreeBoundary
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode r = createTree();
            Boundary(r);
            Console.ReadKey();

        }
        public static void Boundary(TreeNode r)
        {
            leftPath(r);
            leaves(r);
            rightPath(r);

        }


        static TreeNode createTree()
        {
            TreeNode root = new TreeNode(0);
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2); //           0
            TreeNode n3 = new TreeNode(3); //      1         2
            TreeNode n4 = new TreeNode(4); //   3     4   5      6
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);

            root.left = n1;
            root.right = n2;

            n1.left = n3;
            n1.right = n4;

            n2.left = n5;
            n2.right = n6;

            return root;

        }

        /*print and explore left*/
        static void leftPath(TreeNode n)
        {
            if (n == null) return;
            if (n != null && !isLeaf(n) )
            {
                Console.Write(n.Value);
            }
            leftPath(n.left);
        }
        /*we want it to look upwards , first explore and comeback printing*/
        static void rightPath(TreeNode n)
        {
            if (n == null) return;
            rightPath(n.right);
            if (n != null && !isLeaf(n))
            {
                Console.Write(n.Value);
            }
           
        }
        /*regular in-order traversal except we print only the leafs*/
        static void leaves(TreeNode n)
        {
            if (n == null) return;

            leaves(n.left);
            if (isLeaf(n)) Console.Write(n.Value);
            leaves(n.right);
        }

        static bool isLeaf(TreeNode n)
        {
            if (n != null && n.left == null && n.right == null)
                return true;
            return false;
        }


    }
    class TreeNode
    {

        public int Value;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int value)
        {
            this.Value = value;
        }
       

    }


}
