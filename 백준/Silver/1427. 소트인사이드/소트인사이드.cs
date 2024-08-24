using System;
using System.Collections.Generic;
using System.Text;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            List<int> ints = new List<int>();

            foreach (char s in line)
            {
                ints.Add(s - '0');
            }

            ints.Sort();
            ints.Reverse();

            foreach (int i in ints)
            {
                sb.Append(i);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
