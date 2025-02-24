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

            Stack<char> emotionCheck = new Stack<char>();

            string line = sr.ReadLine();

            int happy = 0;
            int sad = 0;

            foreach (char c in line)
            {
                switch (c)
                {
                    case ':':
                        if (emotionCheck.Count <= 0) emotionCheck.Push(':');
                        break;
                    case '-':
                        if (emotionCheck.Count > 0 && emotionCheck.Peek().Equals(':')) emotionCheck.Push('-');
                        else emotionCheck.Clear();
                        break;
                    case ')':
                        if (emotionCheck.Count > 0 && emotionCheck.Peek().Equals('-'))
                        {
                            happy++;
                        }
                        emotionCheck.Clear();
                        break;
                    case '(':
                        if (emotionCheck.Count > 0 && emotionCheck.Peek().Equals('-'))
                        {
                            sad++;
                        }
                        emotionCheck.Clear();
                        break;
                }
            }

            sb.AppendLine((happy > sad) ? "happy" : (happy < sad) ? "sad" : (happy.Equals(0) && sad.Equals(0) ? "none" : "unsure"));

            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}