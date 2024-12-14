using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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


            List<int> ints = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse).ToList();

            ints.Sort();
            
            string command = sr.ReadLine();

            foreach(char c in command)
            {
                switch (c)
                {
                    case 'A':
                        sb.Append($"{ints[0]} ");
                        break;
                    case 'B':
                        sb.Append($"{ints[1]} ");
                        break;
                    case 'C':
                        sb.Append($"{ints[2]} ");
                        break;
                }
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
