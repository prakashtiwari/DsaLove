using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphPract.BFS
{
    public class NumOfEnclave
    {
        public int GetNumOfEnclave(int[][] grid)
        {
            if (grid == null)
                return -1;
            int eclaveCount = 0;
            int m = grid.Length;
            int n = grid[0].Length;
            int[][] visited = new int[m][];
            for (int i = 0; i < m; i++)
            {
                visited[i] = new int[n];
            }
            Console.WriteLine("Reached here");
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == m - 1 || j == n - 1)
                    {
                        if (grid[i][j] == 1)
                        {
                            Console.WriteLine("Reached here a");
                            queue.Enqueue(new Tuple<int, int>(i, j));
                            visited[i][j] = 1;
                        }
                        else
                        {
                            visited[i][j] = 0;
                            Console.WriteLine("Reached here 0");
                        }
                    }
                }
            }
            int[] dRow = new int[] { -1, 0, 1, 0 };
            int[] dCol = new int[] { 0, 1, 0, -1 };
            while (queue.Count > 0)
            {
                Tuple<int, int> item = queue.Dequeue();

                int r = item.Item1;
                int c = item.Item2;
                for (int i = 0; i < 4; i++)
                {
                    int nRow = r + dRow[i];
                    int nCol = c + dCol[i];
                    if (nRow >= 0 && nCol >= 0 && nRow < m && nCol < n && visited[nRow][nCol] == 0 && grid[nRow][nCol] == 1)
                    {
                        queue.Enqueue(new Tuple<int, int>(nRow, nCol));
                        visited[nRow][nCol] = 1;

                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (visited[i][j] == 0 && grid[i][j] == 1)
                    {
                        eclaveCount++;
                    }
                }
            }
            return eclaveCount;
        }
    }
}
