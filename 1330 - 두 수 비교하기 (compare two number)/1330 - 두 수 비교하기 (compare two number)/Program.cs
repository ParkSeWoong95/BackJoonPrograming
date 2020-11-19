using System;

namespace _1330___두_수_비교하기__compare_two_number_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split();
            int A = int.Parse(number[0]);
            int B = int.Parse(number[1]);

            if (A > B)
            {
                Console.WriteLine(">");
            }
            else if (A < B)
            {
                Console.WriteLine("<");
            }
            else if (A == B)
            {
                Console.WriteLine("==");
            }
        }
    }
}
