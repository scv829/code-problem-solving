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
            int[,] dist = new int[inputs[0], inputs[1]];

            Queue<(int, int)> queue = new Queue<(int, int)>();

            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            for (int x = 0; x < inputs[0]; x++)
            {
                string inputPos = sr.ReadLine();

                for (int y = 0; y < inputPos.Length; y++) board[x, y] = (inputPos[y]) - '0';
            }

            for (int x = 0; x < board.GetLength(0); x++)
                for (int y = 0; y < board.GetLength(1); y++)
                    dist[x, y] = -1;

            dist[0, 0] = 0;
            queue.Enqueue((0, 0));

            while (queue.Count > 0)
            {
                (int, int) pos = queue.Dequeue();

                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = pos.Item1 + dx[dir];
                    int ny = pos.Item2 + dy[dir];


                    if (nx < 0 || nx >= board.GetLength(0) || ny < 0 || ny >= board.GetLength(1)) continue;
                    if (dist[nx, ny] >= 0 || board[nx, ny] != 1) continue;

                    dist[nx, ny] = dist[pos.Item1, pos.Item2] + 1;

                    queue.Enqueue((nx, ny));
                }
            }

            sb.Append($"{dist[inputs[0] - 1, inputs[1] - 1] + 1}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}
