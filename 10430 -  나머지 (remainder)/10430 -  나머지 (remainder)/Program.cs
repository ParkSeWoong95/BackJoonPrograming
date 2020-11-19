using System;

namespace _10430____나머지__remainder_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split();

            int A = int.Parse(arr[0]);
            int B = int.Parse(arr[1]);
            int C = int.Parse(arr[2]);

            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}
