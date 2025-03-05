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
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int T = int.Parse(sr.ReadLine());

            for (int i = 0; i < T; i++)
            {
                sr.ReadLine();

                int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                sb.AppendLine($"{inputs.Sum()}");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}