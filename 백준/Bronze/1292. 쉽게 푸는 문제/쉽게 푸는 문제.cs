using System;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int result = 0;
            int count = 0;
            int index = 1;
            while (true)
            {
                for (int j = 0; j < index; j++)
                {
                    count++;
                    if (count >= ints[0])
                    {
                        result += index;
                    }

                    if (count >= ints[1])
                    {
                        Console.WriteLine(result);
                        return;
                    }
                }
                index++;
            }

        }
    }
}