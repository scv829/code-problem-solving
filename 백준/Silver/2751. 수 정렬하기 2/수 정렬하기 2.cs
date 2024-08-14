using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);
            List<int> list = new List<int>();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            list.Sort();

            foreach (int i in list)
            {
                sb.AppendLine($"{i}");
            }

            Console.WriteLine(sb.ToString());

        }
    }
}

