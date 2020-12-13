using System;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (int.Parse(input) < 10)
            {
                input = input + 0;
            }
            int N = int.Parse(input);
            int temp = N;

            int count = 0;
            while (true)
            {
                int number1 = N / 10;
                int number2 = N % 10;
                int sum = number1 + number2;
                N = (number2 * 10) + (sum % 10);
                count++;
                if (N == temp)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}