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

            sr.ReadLine();

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int score = 1;
            int result = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == 1)
                {
                    result += score++;
                }
                else
                {
                    score = 1;
                }
            }

            sb.Append(result);

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}