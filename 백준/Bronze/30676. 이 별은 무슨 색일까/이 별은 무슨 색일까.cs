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

            int input = int.Parse(sr.ReadLine());

            if(620 <= input && input <= 780)
            {
                sb.AppendLine("Red");
            }
            else if (590 <= input && input < 620)
            {
                sb.AppendLine("Orange");
            }
            else if (570 <= input && input < 590)
            {
                sb.AppendLine("Yellow");
            }
            else if (495 <= input && input < 570)
            {
                sb.AppendLine("Green");
            }
            else if (450 <= input && input < 495)
            {
                sb.AppendLine("Blue");
            }
            else if (425 <= input && input < 450)
            {
                sb.AppendLine("Indigo");
            }
            else if (380 <= input && input < 425)
            {
                sb.AppendLine("Violet");
            }


            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
