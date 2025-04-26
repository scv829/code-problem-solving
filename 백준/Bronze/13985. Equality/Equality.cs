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

            string[] inputs = sr.ReadLine().Split(' ');

            sb.Append((int.Parse(inputs[0]) + int.Parse(inputs[2])).Equals(int.Parse(inputs[4])) ? "YES" : "NO");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}