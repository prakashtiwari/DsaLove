using GraphPract.BFS;
using System;

namespace GraphPract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Graph grph = new Graph(9);
            grph.AddEdges(1, 2);
            grph.AddEdges(1, 6);

            grph.AddEdges(2, 3);
            grph.AddEdges(2, 4);

            grph.AddEdges(6, 7);
            grph.AddEdges(6, 9);

            grph.AddEdges(7, 8);
            grph.AddEdges(4, 5);

            string traversedData = grph.BFSTraversal(1);
        }
    }
}
