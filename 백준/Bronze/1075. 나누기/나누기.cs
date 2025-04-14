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
            StringBuilder num = new StringBuilder();

            sb.Clear();
            num.Clear();

            string N = sr.ReadLine();
            int F = int.Parse(sr.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    num.Clear();
                    num.Append($"{N.Substring(0, N.Length - 2)}{i}{j}");
                    if (long.Parse(num.ToString()) % F == 0)
                    {
                        sb.Append($"{i}{j}");
                        break;
                    }
                }

                if (sb.Length > 0)
                {
                    break;
                }
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}