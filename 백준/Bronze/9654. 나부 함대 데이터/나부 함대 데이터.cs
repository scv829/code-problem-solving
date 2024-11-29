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
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{"SHIP NAME      CLASS          DEPLOYMENT IN SERVICE", 15}");
            sb.AppendLine($"{"N2 Bomber      Heavy Fighter  Limited    21        ", 15}");
            sb.AppendLine($"{"J-Type 327     Light Combat   Unlimited  1         ", 11}");
            sb.AppendLine($"{"NX Cruiser     Medium Fighter Limited    18        "}");
            sb.AppendLine($"{"N1 Starfighter Medium Fighter Unlimited  25        "}");
            sb.AppendLine($"{"Royal Cruiser  Light Combat   Limited    4         ", 10}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
