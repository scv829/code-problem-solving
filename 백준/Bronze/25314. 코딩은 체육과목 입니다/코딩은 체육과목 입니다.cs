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

            int N = int.Parse(sr.ReadLine());

            for(int i = 0; i < N / 4; i++)
            {
                sb.Append("long ");
            }
            sb.Append("int");


            sw.Write(sb.ToString());

            sw.Close();
            sr.Close();

        }
    }
}