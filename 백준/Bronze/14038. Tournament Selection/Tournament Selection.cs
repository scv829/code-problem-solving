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

            int win = 0;

            for (int i = 0; i < 6; i++) 
            {
                win = sr.ReadLine().Equals("W") ? win + 1 : win;
            }


            if (win == 0) sb.Append(-1);
            else if(0 < win && win <= 2) sb.Append(3);
            else if(2 < win && win <= 4) sb.Append(2);
            else sb.Append(1);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
