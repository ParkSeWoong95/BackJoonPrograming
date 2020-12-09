using System;
using System.Text;

namespace _2741___N찍기
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder stringbuilder = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                stringbuilder.AppendLine($"{i}");
            }

            Console.WriteLine(stringbuilder.ToString());
        }
    }
}
