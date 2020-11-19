using System;

namespace _1001___A_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);

            Console.WriteLine(A - B);
        }
    }
}
