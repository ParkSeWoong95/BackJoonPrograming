using System;
using System.Diagnostics;

namespace _2577___숫자의_개수
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[3];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            int multiply = input[0] * input[1] * input[2];
            char[] depart = multiply.ToString().ToCharArray();

            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < depart.Length; j++)
                {
                    if (depart[j].ToString() == i.ToString())
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                count = 0;
            }
        }
    }
}
