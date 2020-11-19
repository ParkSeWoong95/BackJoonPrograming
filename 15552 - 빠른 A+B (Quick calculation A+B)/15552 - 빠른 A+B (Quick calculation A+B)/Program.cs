using System;
using System.Text;

namespace _15552___빠른_A_B__Quick_calculation_A_B_
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] a = new int[T];
            int[] b = new int[T];

            for (int i = 0; i < T; i++)
            {
                string[] number = Console.ReadLine().Split(' ');
                a[i] = int.Parse(number[0]);
                b[i] = int.Parse(number[1]);
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int j = 0; j < T; j++)
            {
                stringBuilder.AppendLine($"{a[j] + b[j]}");
            }
            Console.WriteLine(stringBuilder.ToString()?.Trim());

            Console.ReadKey();
        }
    }
}
