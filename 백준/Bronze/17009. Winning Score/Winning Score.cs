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

            int AResult = 0;
            int BResult = 0;

            for(int i = 3; i > 0; i--)
            {
                int num = int.Parse(sr.ReadLine());
                AResult += num * i;
            }

            for (int i = 3; i > 0; i--)
            {
                int num = int.Parse(sr.ReadLine());
                BResult += num * i;
            }

            sb.Append((AResult >= BResult ? (AResult == BResult) ? "T" : "A" : "B"));

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}