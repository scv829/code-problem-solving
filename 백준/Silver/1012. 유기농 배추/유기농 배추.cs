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

            Queue<(int, int)> queue = new Queue<(int, int)>();

            int T = int.Parse(sr.ReadLine());

            int[] dx = { -1, 0, 1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            for (int t = 0; t < T; t++)
            {
                int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                int[,] board = new int[inputs[0], inputs[1]];
                bool[,] vis = new bool[inputs[0], inputs[1]];

                int result = 0;

                for (int i = 0; i < inputs[2]; i++)
                {
                    int[] pos = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                    board[pos[0], pos[1]] = 1;
                }

                for (int x = 0; x < inputs[0]; x++)
                {
                    for (int y = 0; y < inputs[1]; y++)
                    {
                        if (board[x, y] == 0 || vis[x, y]) continue;

                        result++;

                        queue.Enqueue((x, y));

                        while (queue.Count > 0)
                        {
                            (int, int) pos = queue.Dequeue();

                            for (int dir = 0; dir < 4; dir++)
                            {
                                int nx = pos.Item1 + dx[dir];
                                int ny = pos.Item2 + dy[dir];

                                if (nx < 0 || nx >= inputs[0] || ny < 0 || ny >= inputs[1]) continue;
                                if (vis[nx, ny] || board[nx, ny] != 1) continue;

                                vis[nx, ny] = true;

                                queue.Enqueue((nx, ny));
                            }
                        }

                    }
                }

                sb.AppendLine($"{result}");

            }


            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}
