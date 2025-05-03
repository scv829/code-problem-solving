using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int[,] board = new int[inputs[0], inputs[1]];
            bool[,] vis = new bool[inputs[0], inputs[1]];

            Queue<(int, int)> queue = new Queue<(int, int)>();

            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            int map = 0;
            int max = 0;
            int count = 0;

            for (int x = 0; x < inputs[0]; x++)
            {
                int[] inputPos = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                for (int y = 0; y < inputPos.Length; y++) board[x, y] = inputPos[y];
            }

            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    if (board[x, y] == 1 && !vis[x, y])
                    {
                        vis[x, y] = true;
                        queue.Enqueue((x, y));
                        count++;
                        map++;

                        while (queue.Count > 0)
                        {
                            (int, int) pos = queue.Dequeue();

                            for (int dir = 0; dir < 4; dir++)
                            {
                                int nx = pos.Item1 + dx[dir];
                                int ny = pos.Item2 + dy[dir];

                                if (nx < 0 || nx >= board.GetLength(0) || ny < 0 || ny >= board.GetLength(1)) continue;
                                if (vis[nx, ny] || board[nx, ny] != 1) continue;

                                vis[nx, ny] = true;
                                queue.Enqueue((nx, ny));
                                count++;
                            }
                        }

                        max = Math.Max(max, count);
                        count = 0;
                    }
                }
            }

            sb.Append($"{map}\n{max}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}
