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

            int T = int.Parse(sr.ReadLine());

            for (int i = 0; i < T; i++)
            {
                long[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), long.Parse);

                int count = 0;
                long goal_dis = inputs[1] - inputs[0];
                long cur_dis = 0;
                
                long step = 0;

                while(true)
                {
                    step += 1;
                    cur_dis += step * 2;
                    count += 2;

                    if (cur_dis - step >= goal_dis)
                    {
                        sb.AppendLine($"{count - 1}");
                        break;
                    }
                    else if (cur_dis >= goal_dis)
                    {
                        sb.AppendLine($"{count}");
                        break;
                    }
                }

            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}