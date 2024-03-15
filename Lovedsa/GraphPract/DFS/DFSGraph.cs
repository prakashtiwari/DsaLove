using System.Collections.Generic;

namespace GraphPract.DFS
{
    public class DFSGraph
    {
        List<int>[] adjList;
        bool[] visited;
        public DFSGraph(int v)
        {
            adjList = new List<int>[v + 1];

            visited = new bool[v + 1];
            for (int i = 0; i < adjList.Length; i++)
            {

                adjList[i] = new List<int>();
            }
        }
        public void AddEdges(int v, int e)
        {
            adjList[v].Add(e);
            adjList[e].Add(v);
        }

        public void DFSTraversal(int root, bool[] visited, List<int> result)
        {
            visited[root] = true;
            List<int> lstNode = adjList[root];
            result.Add(root);
            foreach (var node in lstNode)
            {
                if (!visited[node])
                {
                    //visited[node] = true;
                    //result.Add(node);
                    DFSTraversal(node, visited, result);
                }
            }
        }
    }
}
