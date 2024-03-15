using GraphPract.BFS;
using GraphPract.DFS;
using System;
using System.Collections.Generic;

namespace GraphPract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Graph grph = new Graph(9);
            //grph.AddEdges(1, 2);
            //grph.AddEdges(1, 6);

            //grph.AddEdges(2, 3);
            //grph.AddEdges(2, 4);

            //grph.AddEdges(6, 7);
            //grph.AddEdges(6, 9);

            //grph.AddEdges(7, 8);
            //grph.AddEdges(4, 5);

            //string traversedData = grph.BFSTraversal(1);


            //DFSGraph graph = new DFSGraph(9);
            //graph.AddEdges(1, 2);
            //graph.AddEdges(1, 6);

            //graph.AddEdges(2, 3);
            //graph.AddEdges(2, 4);

            //graph.AddEdges(6, 7);
            //graph.AddEdges(6, 9);

            //graph.AddEdges(7, 8);
            //graph.AddEdges(4, 5);
            //List<int> list = new List<int>();
            //bool[] visited = new bool[10];
            //graph.DFSTraversal(1,  visited, list);

            int numOfNodes = 9;
            NumOfIland numOfIland = new NumOfIland(numOfNodes);
            numOfIland.AddEdges(1, 2);
            numOfIland.AddEdges(2, 3);
            numOfIland.AddEdges(2, 1);
            numOfIland.AddEdges(3, 2);
            numOfIland.AddEdges(4, 5);
            numOfIland.AddEdges(5, 4);
            numOfIland.AddEdges(5, 6);
            numOfIland.AddEdges(6, 5);
            numOfIland.AddEdges(7, 8);
            numOfIland.AddEdges(8, 7);
            numOfIland.AddEdges(8, 9);
           // numOfIland.AddEdges(10, 9);
            int result = numOfIland.GetNumOfComponent(numOfNodes);
        }
    }
}
