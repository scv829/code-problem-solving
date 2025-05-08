using System;
using System.IO;
using System.Text;

namespace code
{
    class Program
    {

        static int n, m;
        static int[] arr = new int[10];
        static bool[] isUsed = new bool[10];

        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            n = inputs[0];
            m = inputs[1];

            Func(0, sb);

            sw.Write(sb.ToString());

            sw.Close();
            sr.Close();
        }
        static void Func(int k, StringBuilder sb)
        {
            if(k == m)
            {
                for(int i = 0; i < m; i++)
                {
                    sb.Append($"{arr[i]} ");
                }
                sb.AppendLine();
                return;
            }

            for(int i = 1; i <= n; i++)
            {
                if (!isUsed[i])
                {
                    arr[k] = i;
                    isUsed[i] = true;
                    Func(k + 1, sb);
                    isUsed[i] = false;
                }
            }
        }
    }
}
