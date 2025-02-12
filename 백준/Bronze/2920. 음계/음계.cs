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

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int a = 1;
            int d = 8;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == a)
                {
                    a++;
                }
                else if (inputs[i] == d)
                {
                    d--;
                }

            }

            if (a == 9) sb.Append("ascending");
            else if (d == 1) sb.Append("descending");
            else sb.Append("mixed");

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}