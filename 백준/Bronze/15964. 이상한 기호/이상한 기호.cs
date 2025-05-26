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

            long[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), long.Parse);

            sb.Append((inputs[0] + inputs[1]) * (inputs[0] - inputs[1]));
            
            sw.WriteLine(sb.ToString());    

            sw.Close();
            sr.Close();
        }

    }
}
