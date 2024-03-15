using System.Collections.Generic;

namespace GraphPract.DFS
{
    public class NumOfIland
    {
        List<int>[] adj = null;

        public NumOfIland(int v)
        {
            adj = new List<int>[v + 1];
            for (int i = 0; i < adj.Length; i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void AddEdges(int u, int v)
        {
            adj[u].Add(v);
        }
        public void Dfs(int root, ref bool[] v)
        {
            v[root] = true;
            var adjItem = adj[root];
            for (int i = 0; i < adjItem.Count; i++)
            {
                if (!v[adjItem[i]])
                {
                    Dfs(adjItem[i],ref v);
                }
            }

        }
        public int GetNumOfComponent(int numOfNodes)
        {
            bool[] visited = new bool[numOfNodes + 1];
            int count = 0;
            for (int i = 1; i <= numOfNodes; i++)
            {
                if (!visited[i])
                {

                    Dfs(i, ref visited);
                    count++;
                }
            }
            return count;
        }
    }
}
