using System;
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

            int N = int.Parse(sr.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }

            foreach (int i in arr.OrderBy(x => x).Reverse())
            {
                sb.AppendLine($"{i}");
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}