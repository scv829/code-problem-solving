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

            int t = int.Parse(sr.ReadLine());
            int[] result = new int[2];

            for(int i = 0; i < t; i++)
            {
                int n = int.Parse(sr.ReadLine());

                for(int j = 0; j < n; j++)
                {
                    char[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '),  char.Parse);

                    switch(inputs[0])
                    {
                        case 'R':
                            if (inputs[1].Equals('P')) result[1]++;
                            else if (inputs[1].Equals('S')) result[0]++;
                            break;
                        case 'P':
                            if (inputs[1].Equals('R')) result[0]++;
                            else if (inputs[1].Equals('S')) result[1]++;
                            break;
                        case 'S':
                            if (inputs[1].Equals('R')) result[1]++;
                            else if (inputs[1].Equals('P')) result[0]++;
                            break;
                    }
                }
                sb.AppendLine($"{(result[0].Equals(result[1]) ? "TIE" : (result[0] > result[1]) ? "Player 1" : "Player 2") }");
                result[0] = result[1] = 0;
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
