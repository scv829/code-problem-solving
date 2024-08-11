using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int T);
            StringBuilder sb = new StringBuilder();

            List<int> list = new List<int>();

            for (int i = 0; i < T; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                foreach (string s in line) list.Add(int.Parse(s));

                list.Sort();

                sb.Append(list[list.Count - 3] + "\n");
                list.Clear();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

