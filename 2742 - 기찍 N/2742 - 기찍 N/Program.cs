using System;
using System.Text;

namespace _2742___기찍_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder stringbuilder = new StringBuilder();

            for (int i = n; i > 0; i--)
            {
                stringbuilder.AppendLine($"{i}");
            }
            Console.WriteLine(stringbuilder.ToString());
        }
    }
}
