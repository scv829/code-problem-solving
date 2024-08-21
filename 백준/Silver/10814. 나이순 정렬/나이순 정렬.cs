using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);

            List<(int, string, int)> users = new List<(int, string, int)>();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                users.Add((int.Parse(line[0]), line[1], i));
            }

            IEnumerable<(int, string, int)> result = users.OrderBy(x => x.Item1);

            foreach ((int, string, int) n in result)
            {
                sb.AppendLine($"{n.Item1} {n.Item2}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
