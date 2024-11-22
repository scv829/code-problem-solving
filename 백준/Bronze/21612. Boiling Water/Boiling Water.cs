using System;
using System.IO;
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


            int B = int.Parse(sr.ReadLine());

            int P = 5 * B - 400;

            sb.AppendLine($"{P}");
            sb.AppendLine($"{(P == 100 ? 0 : (P > 100) ? -1 : 1)}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
