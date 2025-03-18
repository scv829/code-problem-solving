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

            int[] lens = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int[] newArr = new int[lens[0] + lens[1]];

            sb.Append($"{sr.ReadLine()} {sr.ReadLine()}");

            newArr = Array.ConvertAll(sb.ToString().Split(' '), int.Parse);

            sb.Clear();

            foreach (int num in newArr.OrderBy(x => x))
            {
                sb.Append($"{num} ");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}