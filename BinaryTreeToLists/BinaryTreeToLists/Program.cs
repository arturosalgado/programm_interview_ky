using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeToLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {3 ,1 ,4, 0, 5, 2, 6};
            Node<int> t = createTree(a, 0, a.Length - 1);
            print(t);
            List<List<Node<int>>> final_list = getListOfLists(t);

            foreach (var list in final_list)
            {
                foreach (var element in list)
                {
                    Console.Write(" E {0} - ",element);

                }
            }
            

            Console.ReadKey();
        }
        static void print(Node<int> t)
        {
            if (t == null) return;

            
          
            print(t.Left);
            Console.Write(" {0} ", t.Value);
            print(t.Right);
           
        }
        static Node<int> createTree(int []a,  int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end)/2;
            Node<int> node = new Node<int>(a[mid]);
            node.Left =  createTree(a, start,mid-1);
            node.Right = createTree(a,mid + 1,end);
          
            return node;
        }

        static List<List<Node<int>>> getListOfLists(Node<int> node)
        {

            List<List<Node<int>>>  lists  = new   List<List<Node<int>>>();

            List<Node<int>> current_list = new List<Node<int>>();

            if (node != null)
            {
                current_list.Add(node);
            }
            while (current_list.Count > 0)
            {
                lists.Add(current_list);
                List<Node<int>> parents = current_list;

                current_list = new List<Node<int>>();

                foreach (var parent in parents)
                {
                    if (parent.Left != null) {
                        current_list.Add(parent.Left);
                    }
                    if (parent.Right != null)
                    {
                        current_list.Add(parent.Right);
                    }
                }

            }


            return lists;

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
            return this.Value+"";
        }
    }

}
