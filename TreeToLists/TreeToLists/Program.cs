using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeToLists
{
    class Program
    {
        static void Main(string[] args)
        {

            TreeNode t = createTree();
            print(t);
            Console.WriteLine("");
            Console.WriteLine("press key");

            List<LinkedList<TreeNode>> lists = new List<LinkedList<TreeNode>>();

            createLists(t,lists,0);

            foreach (var l in lists)
            {
                Console.WriteLine("New List ");
                foreach(TreeNode n in l){
                    Console.WriteLine("element {0}",n);
                }
            }

            visualizeLevels(t,0);

            Console.ReadKey();
        }

        static void createLists(TreeNode n, List<LinkedList<TreeNode>> lists,int level )
        {
            if (n == null) return;

            LinkedList<TreeNode> list = new LinkedList<TreeNode>();

            if (lists.Count == level)
                lists.Add(list);
            else
                list = lists.ElementAt(level);
            
            list.AddLast(n);
            createLists(n.left, lists, level + 1);
            createLists(n.right, lists, level + 1);

        }


        static void visualizeLevels(TreeNode n, int level)
        {
            level = level + 1;
            if (n == null) return;

            Console.WriteLine("n is {0} level is {1}",n,level);
            visualizeLevels(n.left,level);
            visualizeLevels(n.right,level);

        }


        
        

        static void print(TreeNode t)
        {
            if (t==null) return;
            
            print(t.left);
            Console.Write(" {0}",t.Value);
            print(t.right);
          
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

        public override string ToString()
        {
            return this.Value+" ";
        }

    }

}
