using System;

namespace _1008___A_B__Devide_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();

            double A = double.Parse(ss[0]);
            double B = double.Parse(ss[1]);

            Console.WriteLine(A / B);
        }
    }
}
