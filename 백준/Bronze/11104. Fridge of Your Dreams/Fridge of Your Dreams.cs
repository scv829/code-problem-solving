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

            int N = int.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++) 
            { 
                int num = Convert.ToInt32(sr.ReadLine(), 2);
                sb.AppendLine($"{num}"); 
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
