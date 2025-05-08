using System;
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

            long[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), long.Parse);

            sb.Append(POW(inputs[0], inputs[1], inputs[2]));

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
        static long POW(long a, long b, long m)
        {
            if (b == 1) return a % m;
            long val = POW(a, b / 2, m);
            val = val * val % m;
            return (b % 2 == 0) ? val : val * a % m;
        }
    }
}
