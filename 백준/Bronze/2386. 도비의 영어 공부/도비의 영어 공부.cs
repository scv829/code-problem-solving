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

            while (true)
            {
                string[] inputs = sr.ReadLine().Split(' ');

                if (inputs[0].Equals("#")) break;
                int result = 0;
                char c = inputs[0].ToLower().ToCharArray()[0];
                char C = inputs[0].ToUpper().ToCharArray()[0];
                for (int i = 1; i < inputs.Length; i++)
                {
                    for(int j = 0; j < inputs[i].Length; j++)
                    {
                        if (inputs[i][j].Equals(c) || inputs[i][j].Equals(C)) result++;
                    }
                }
                sb.AppendLine($"{inputs[0]} {result}");
                result = 0;
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
