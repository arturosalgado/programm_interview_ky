using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThereAPath2
{
    class Graph
    {

        private const int NUM_VERTICES = 9;
        public Vertex[] vertices;
        private int[,] adjMatrix;
        int numVerts;
        public Graph()
        {
            vertices = new Vertex[NUM_VERTICES];
            adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
            numVerts = 0;
            for (int j = 0; j < NUM_VERTICES; j++)
                for (int k = 0; k < NUM_VERTICES; k++)
                    adjMatrix[j, k] = 0;
        }
        public void AddVertex(string label)
        {
            vertices[numVerts] = new Vertex(label);
            numVerts++;
        }

        public void AddEdge(string LabelOrigin, string LabelEnd)
        {

            int? indexOrigin = this.getIndex(LabelOrigin);
            int? indexEnd = this.getIndex(LabelEnd);

            if (indexOrigin.HasValue && indexEnd.HasValue)
            {
                AddEdge((int)indexOrigin, (int)indexEnd);
            }

        }

        public int getIndex(string label)
        {
            for (int i = 0; i < this.vertices.Length; i++)
            {
                Vertex v = (Vertex)vertices[i];
                if (v.label == label) return i;
            }

            return -1;
        }

        public void AddEdge(int start, int eend)
        {
            adjMatrix[start, eend] = 1;
            adjMatrix[eend, start] = 1;
        }
        public void ShowVertex(int v)
        {
            Console.Write(vertices[v].label + " ");
            Console.WriteLine("");
            Console.ReadKey();
        }
        public void ShowVertex(Vertex v)
        {
            Console.Write(v.label + " ");
            Console.WriteLine("");
            Console.ReadKey();
        }

        public int GetAdjUnvisitedVertex(int v)
        {
            for (int j = 0; j <= NUM_VERTICES - 1; j++)
                if ((adjMatrix[v, j] == 1) && (vertices[j].visited == false))
                    return j;
            return -1;
        }

        public Vertex GetAdjUnvisitedVertex(Vertex v)
        {
            int i = getIndex(v.label);

            for (int j = 0; j <= NUM_VERTICES - 1; j++)
                if ((adjMatrix[i, j] == 1) && (vertices[j].visited == false))
                    return vertices[j];
            return null;
        }

        public void dsf()
        {

            Stack<int> stack = new Stack<int>();


            Console.WriteLine("Pushing the starting vertex {0} to the stack", vertices[0].label);
            vertices[0].visited = true;
            ShowVertex(0);
            stack.Push(0);

            int v;
            while (stack.Count > 0)
            {
                int peek = stack.Peek();
                Console.WriteLine("Peak is {0} ", vertices[peek].label); Console.ReadKey();
                v = GetAdjUnvisitedVertex(peek);
                if (v == -1)
                {
                    int p = stack.Pop();
                    Console.WriteLine("No adjacent unvisited vertices found, popping <--{0}", vertices[p]);

                }
                else
                {
                    Console.WriteLine("Found {0} which is {1}", v, vertices[v].label);
                    Console.ReadKey();
                    vertices[v].visited = true;
                    ShowVertex(v);
                    Console.WriteLine("Pushing {0} to the stack", vertices[v].label);
                    stack.Push(v);
                }
            }







        }

        public void showMatrix()
        {

            string[] a = { "A", "B", "C", "D", "E", "F", "G", "H" ,"I"};

            Console.WriteLine("");
            Console.Write("  ");
            for (int i = 0; i < NUM_VERTICES; i++)
            {
                Console.Write("{0}   ", a[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i < NUM_VERTICES; i++)
            {
                Console.Write("{0}", a[i]);
                for (int j = 0; j < NUM_VERTICES; j++)
                {
                    Console.Write("[{0}] ", adjMatrix[i, j]);
                }
                Console.WriteLine("");
            }

        }


        public void beathsearchfirst()
        {
            Queue<int> queue = new Queue<int>();

            vertices[0].visited = true;
            ShowVertex(0);
            queue.Enqueue(0);

            while (queue.Count > 0)
            {
                int vert = queue.Dequeue();
                int vert2 = GetAdjUnvisitedVertex(vert);
                while (vert2 != -1)
                {
                    vertices[vert2].visited = true;
                    ShowVertex(vert2);
                    queue.Enqueue(vert2);
                    vert2 = GetAdjUnvisitedVertex(vert);
                }

            }

        }


        public bool path(Vertex a, Vertex b)
        {
            Queue<Vertex> queue = new Queue<Vertex>();

            a.visited = true;
            ShowVertex(a);
            queue.Enqueue(a);

            while (queue.Count > 0)
            {
                Vertex vert = queue.Dequeue();
                Vertex vert2 = GetAdjUnvisitedVertex(vert);
                while (vert2 != null)
                {
                    vert2.visited = true;
                    ShowVertex(vert2);
                   
                    if (vert2 == b)
                        return true;
                    else
                    queue.Enqueue(vert2);
                    vert2 = GetAdjUnvisitedVertex(vert);
                }

            }

            return false;

        }

    }
}
