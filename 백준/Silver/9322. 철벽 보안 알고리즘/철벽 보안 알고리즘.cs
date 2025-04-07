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

            Queue<string> onePublicKey = new Queue<string>();
            Dictionary<string, string> twoPublicKey = new Dictionary<string, string>();

            int T = int.Parse(sr.ReadLine());
            int N = 0;
            string[] arr1;
            string[] arr2;

            for (int i = 0; i < T; i++)
            {
                N = int.Parse(sr.ReadLine());

                onePublicKey.Clear();
                twoPublicKey.Clear();

                arr1 = sr.ReadLine().Split(' ');
                foreach (string s in arr1) { onePublicKey.Enqueue(s); }

                arr1 = sr.ReadLine().Split(' ');
                arr2 = sr.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    twoPublicKey.Add(arr1[j], arr2[j]);
                }

                while (onePublicKey.Count > 0)
                {
                    sb.Append($"{twoPublicKey[onePublicKey.Dequeue()]} ");
                }

                sb.AppendLine();
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}