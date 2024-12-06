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
            StringBuilder line = new StringBuilder();

            // R C ZR ZC
            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            for(int i = 0; i < inputs[0]; i++)
            {
                string chars = sr.ReadLine();

                for (int j = 0; j < inputs[1]; j++) 
                {
                    for(int time = 0; time < inputs[3]; time++)
                    {
                        line.Append(chars[j]);
                    }
                }

                for(int time = 0; time < inputs[2]; time++)
                {
                    sb.AppendLine(line.ToString());
                }
                line.Clear();

            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
