using System;

namespace _2884___알람_시계__Alarm_Clock_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int h = int.Parse(a[0]);
            int m = int.Parse(a[1]);
            if (h < 0 || h > 24 || m < 0 || m > 59) return;

            if (m < 45)
            {
                h--;
                m += 15;

                if (h < 0)
                {
                    h = 23;
                }
            }
            else
            {
                m -= 45;
            }

            Console.WriteLine("{0} {1}", h, m);
        }
    }
}
