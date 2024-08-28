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
            StringBuilder sb = new StringBuilder();

            string[] line = Console.ReadLine().Split(' ');

            int N = int.Parse(line[0]);
            int K = int.Parse(line[1]);

            List<int> result = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).ToList();

            result.Sort();

            sb.Append(result[K - 1]);

            Console.WriteLine(sb.ToString());
        }
    }
}
