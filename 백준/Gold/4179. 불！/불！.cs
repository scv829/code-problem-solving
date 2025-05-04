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

            sb.Clear();

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            string[] board = new string[inputs[0]];
            int[,] jihoon_dist = new int[inputs[0], inputs[1]];
            int[,] fire_dist = new int[inputs[0], inputs[1]];

            Queue<(int, int)> jihoon_queue = new Queue<(int, int)>();
            Queue<(int, int)> fire_queue = new Queue<(int, int)>();

            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            for (int x = 0; x < inputs[0]; x++)
            {
                board[x] = sr.ReadLine();
            }

            for (int x = 0; x < inputs[0]; x++)
            {
                for (int y = 0; y < inputs[1]; y++)
                {
                    if (board[x][y] == 'F')
                    {
                        fire_queue.Enqueue((x, y));
                        fire_dist[x, y] = 0;
                    }
                    else if (board[x][y] == 'J')
                    {
                        jihoon_queue.Enqueue((x, y));
                        jihoon_dist[x, y] = 0;
                    }
                    else
                    {
                        jihoon_dist[x, y] = -1;
                        fire_dist[x, y] = -1;
                    }
                }
            }

            while (fire_queue.Count > 0)
            {
                (int, int) pos = fire_queue.Dequeue();

                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = pos.Item1 + dx[dir];
                    int ny = pos.Item2 + dy[dir];

                    if (nx < 0 || nx >= inputs[0] || ny < 0 || ny >= inputs[1]) continue;
                    if (fire_dist[nx, ny] >= 0 || board[nx][ny] == '#') continue;

                    fire_dist[nx, ny] = fire_dist[pos.Item1, pos.Item2] + 1;

                    fire_queue.Enqueue((nx, ny));
                }
            }

            while (jihoon_queue.Count > 0)
            {
                (int, int) pos = jihoon_queue.Dequeue();

                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = pos.Item1 + dx[dir];
                    int ny = pos.Item2 + dy[dir];

                    if (nx < 0 || nx >= inputs[0] || ny < 0 || ny >= inputs[1])
                    {
                        jihoon_queue.Clear();
                        sb.Append($"{jihoon_dist[pos.Item1, pos.Item2] + 1}");
                        break;
                    }
                    if (jihoon_dist[nx, ny] >= 0 || board[nx][ny] == '#') continue;
                    if (fire_dist[nx, ny] != -1 && fire_dist[nx, ny] <= jihoon_dist[pos.Item1, pos.Item2] + 1) continue;

                    jihoon_dist[nx, ny] = jihoon_dist[pos.Item1, pos.Item2] + 1;

                    jihoon_queue.Enqueue((nx, ny));
                }
            }

            if (sb.Length <= 0) sb.Append("IMPOSSIBLE");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}
