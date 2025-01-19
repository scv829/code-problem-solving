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
            StringBuilder sum = new StringBuilder();

            while(true)
            {

                string input = sr.ReadLine();

                if(input == "#") break;

                double result = 0;

                for(int i = 0; i < input.Length; i++)
                {
                    int num = 0;
                    switch (input[i])
                    {
                        case '-':
                            num = 0;
                            break;
                        case '\\':
                            num = 1;
                            break;
                        case '(':
                            num = 2;
                            break;
                        case '@':
                            num = 3;
                            break;
                        case '?':
                            num = 4;
                            break;
                        case '>':
                            num = 5;
                            break;
                        case '&':
                            num = 6;
                            break;
                        case '%':
                            num = 7;
                            break;
                        case '/':
                            num = -1;
                            break;
                    }
                    result += num * Math.Pow(8, input.Length - 1 - i);
                }

                sb.AppendLine($"{result}");
            }
            
            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}