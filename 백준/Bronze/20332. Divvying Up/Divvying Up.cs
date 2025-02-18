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

            int N = int.Parse(sr.ReadLine());
            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            sb.Append((inputs.Sum() % 3 == 0) ? "yes" : "no");

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}