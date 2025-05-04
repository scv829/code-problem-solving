using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            int[] dist = Enumerable.Repeat(-1, 100002).ToArray();

            int[] dx = new int[] { -1, 1, 2 };

            Queue<int> queue = new Queue<int>();

            dist[inputs[0]] = 0;
            queue.Enqueue(inputs[0]);

            while (dist[inputs[1]] == -1)
            {
                int pos = queue.Dequeue();

                for (int dir = 0; dir < dx.Length; dir++)
                {
                    int nx = (dir == dx.Length - 1) ? pos * dx[dir] : pos + dx[dir];

                    if (nx < 0 || nx > 100000) continue;
                    if (dist[nx] != -1) continue;

                    dist[nx] = dist[pos] + 1;

                    queue.Enqueue(nx);
                }
            }

            sb.Append(dist[inputs[1]]);

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}
