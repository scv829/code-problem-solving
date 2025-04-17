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

            for (int i = 0; i < N; i++)
            {
                string[] inputs = sr.ReadLine().Split(' ');

                for (int j = 2; j < inputs.Length; j++)
                {
                    sb.Append($"{inputs[j]} ");
                }

                for (int j = 0; j < 2; j++)
                {
                    sb.Append($"{inputs[j]} ");
                }

                sb.AppendLine();
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}