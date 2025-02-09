using System;
using System.Collections.Generic;
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
            StringBuilder inputSB = new StringBuilder();
            StringBuilder sb = new StringBuilder();

            string line = sr.ReadLine();

            int[] inputs = Array.ConvertAll(line.Split(' '), int.Parse);

            int temp = 0;

            Stack<string> strings = new Stack<string>();

            strings.Push(line);

            while (true)
            {
                if (inputs[0] == 1 && inputs[1] == 2 && inputs[2] == 3 && inputs[3] == 4 && inputs[4] == 5) break;

                for (int i = 0; i < inputs.Length - 1; i++)
                {
                    if (inputs[i] > inputs[i + 1])
                    {
                        temp = inputs[i];
                        inputs[i] = inputs[i + 1];
                        inputs[i + 1] = temp;
                    }

                    inputSB.Append($"{inputs[0]} {inputs[1]} {inputs[2]} {inputs[3]} {inputs[4]}");


                    if (!strings.Peek().Equals(inputSB.ToString()))
                    {
                        strings.Push(inputSB.ToString());
                        sb.AppendLine(inputSB.ToString());
                    }

                    inputSB.Clear();
                }
            }


            if (sb.Length == 0)
            {
                sb.Append("1 2 3 4 5");
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}