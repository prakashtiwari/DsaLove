using System;
using System.Collections.Generic;
using System.Text;

namespace GraphPract.BFS
{
    public class Graph
    {
        int V;
        List<int>[] adjList;
        bool[] visited;
        public Graph(int v)
        {
            adjList = new List<int>[v + 1];
            visited = new bool[v + 1];
            for (int i = 0; i < adjList.Length; i++)
            {
                adjList[i] = new List<int>();
            }
        }
        public void AddEdges(int u, int v)
        {
            adjList[u].Add(v);
            adjList[v].Add(u);
        }

        public string BFSTraversal(int root)
        {
            StringBuilder traversed = new StringBuilder();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(root);
            traversed.Append(" " + root);
            visited[root] = true;
            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                var nodes = adjList[node];
                for (int i = 0; i < nodes.Count; i++)
                {
                    int adjNode = nodes[i];
                    if (!visited[adjNode])
                    {
                        visited[adjNode] = true;
                        queue.Enqueue(adjNode);
                        traversed.Append(" " + adjNode);
                    }
                }
            }
            return traversed.ToString();
        }

        private StringBuilder StringBuilder()
        {
            throw new NotImplementedException();
        }
    }
}

