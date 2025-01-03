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
            Stack<char> stack = new Stack<char>();

            string[] inputs = sr.ReadLine().Split(' ');

            sb.Append(Math.Max(int.Parse(new string(inputs[0].Reverse().ToArray())), int.Parse(new string(inputs[1].Reverse().ToArray()))));

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
