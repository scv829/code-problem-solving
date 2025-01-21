using System.Linq;
using System.Numerics;
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
            
            int n = int.Parse(sr.ReadLine());
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            sb.Append(result);


            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}