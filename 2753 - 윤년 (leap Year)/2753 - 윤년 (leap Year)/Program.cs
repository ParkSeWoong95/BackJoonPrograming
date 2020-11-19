using System;

namespace _2753___윤년__leap_Year_
{
    class Program
    {
        static void Main(string[] args)
        {
            int leapYear = int.Parse(Console.ReadLine());

            if (leapYear % 4 == 0 && leapYear % 100 != 0 || leapYear % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
