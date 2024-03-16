using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphPract.BFS
{
    public class RottenOrange
    {
        public int OrangesRotting(int[][] grid)
        {
            int totalTime = 0;
            return totalTime;
        }
        private int GetOrangesRotting(int[][] grid)
        {
            int totalTime = 0;
            int m = grid.Length;
            int n = grid[0].Length;
            int[][] visited = new int[m][];
            for (int i = 0; i < m; i++)
            {
                visited[i] = new int[n];
            }

            Queue<Tuple<int, int, int>> queue = new Queue<Tuple<int, int, int>>();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        Tuple<int, int, int> tup = new Tuple<int, int, int>(i, j, 0);
                        queue.Enqueue(tup);
                        visited[i][j] = 2;
                    }
                    else
                    {
                        visited[i][j] = 0;
                    }
                }
            }
            //Delta to move up and down
            int[] dRow = new int[] { -1, 0, 1, 0 };
            int[] dCol = new int[] { 0, 1, 0, -1 };
            int tm = 0;
            while (queue.Count > 0)
            {
                var qItem = queue.Dequeue();
                int r = qItem.Item1;
                int col = qItem.Item2;
                int count = qItem.Item3;
                tm = Math.Max(tm, count);
                for (int i = 0; i < 4; i++)
                {
                    int nRow = r + dRow[i];
                    int nCol = col + dCol[i];
                    if (nRow >= 0 && nRow < m && nCol >= 0 && nCol < n && visited[nRow][nCol] != 2 && grid[nRow][nCol] == 1)
                    {
                        visited[nRow][nCol] = 2;
                        queue.Enqueue(new Tuple<int, int, int>(nRow, nCol, count + 1));
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (visited[i][j] == 0 && grid[i][j] == 1)
                       return -1;
                }
            }

            return tm;
        }
    }
}
