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

            int S = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse).Sum();
            int T = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse).Sum();

            sb.Append($"{(S < T ? T : S)}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}