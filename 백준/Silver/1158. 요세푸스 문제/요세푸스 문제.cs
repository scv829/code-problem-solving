using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            LinkedListNode<int> node;
            
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            int N = int.Parse(numbers[0]);
            int K = int.Parse(numbers[1]);

            int[] result = new int[N];
            int index = 0;

            for (int i = 1; i <= N; i++)
            {
                list.AddLast(i);
            }

            node = list.First;

            while (list.Count != 0)
            {
                for (int i = 0; i < K - 1; i++)
                {
                    node = node.Next != null ? node.Next : list.First;
                }
                result[index++] = node.Value;
                LinkedListNode<int> remove = node;
                node = node.Next != null ? node.Next : list.First;
                list.Remove(remove);
            }
            Console.Write("<");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{result[i]}");
                if (i < result.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(">");
        }
    }
}
