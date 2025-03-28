using System;
using System.Collections.Generic;
using System.Text;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            StringBuilder sb = new StringBuilder();

            int.TryParse(Console.ReadLine(), out int N);

            for (int i = 1; i <= N; i++)
            {
                queue.Enqueue(i);
            }

            while (queue.Count > 1)
            {
                queue.Dequeue();
                queue.Enqueue(queue.Dequeue());
            }

            sb.Append(queue.Peek());

            Console.WriteLine(sb.ToString());
        }
    }
}
