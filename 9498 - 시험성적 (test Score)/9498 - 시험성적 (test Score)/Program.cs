using System;

namespace _9498___시험성적__test_Score_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 시험성적
            int testScore = int.Parse(Console.ReadLine());

            if (testScore >= 90 && testScore <= 100)
            {
                Console.WriteLine("A");
            }
            else if (testScore >= 80 && testScore < 90)
            {
                Console.WriteLine("B");
            }
            else if (testScore >= 70 && testScore < 80)
            {
                Console.WriteLine("C");
            }
            else if (testScore >= 60 && testScore < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
