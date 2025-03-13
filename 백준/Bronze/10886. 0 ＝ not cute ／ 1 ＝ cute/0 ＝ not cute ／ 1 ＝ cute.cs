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

            int cute = 0;
            int notCute = 0;

            for(int i = 0; i < N; i++)
            {
                if (string.Equals(sr.ReadLine(), "1")) cute++;
                else notCute++;
                 
            }

            sb.Append((cute > notCute) ? "Junhee is cute!" : "Junhee is not cute!");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}