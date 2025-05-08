using System;
using System.IO;
using System.Text;

namespace code
{
    class Program
    {

        static int n, count, sum;
        static int[] arr;

        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            n = inputs[0];
            sum = inputs[1];

            arr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            count = 0;

            Func(0, 0);

            sb.Append($"{((sum == 0) ? count - 1 : count)}");

            sw.Write(sb.ToString());

            sw.Close();
            sr.Close();
        }
        static void Func(int cur, int total)
        {
            if (cur == n)
            {
                if (total == sum) count++;
                return;
            }

            Func(cur + 1, total);
            Func(cur + 1, total + arr[cur]);
        }
    }
}
