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

            for(int i = 0; i < 5; i++)
            {
                if(sr.ReadLine().Contains("FBI")) sb.Append($"{i + 1} ");
            }

            if (sb.Length == 0) sb.Append("HE GOT AWAY!");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
