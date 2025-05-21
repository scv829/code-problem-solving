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

            int[] airport = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int[] consumer = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            sb.Append((airport[0] >= consumer[0] ? 0 : consumer[0] - airport[0]) +
                      (airport[1] >= consumer[1] ? 0 : consumer[1] - airport[1]) +
                      (airport[2] >= consumer[2] ? 0 : consumer[2] - airport[2]));


            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
