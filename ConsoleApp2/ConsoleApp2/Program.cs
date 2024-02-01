using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double s = 0;
            int k = 1;
            //int k = 15;

            while (k <= 15)
            {
                s += k * x * Math.Sin(x);
                k++;
            }

            //do
            //{
            //    s += k * x * Math.Sin(x);
            //}
            //while (++k <= 15);

            //while (k >= 1)
            //{
            //    s += k * x * Math.Sin(x);
            //    k--;
            //}

            //do
            //{
            //    s += k * x * Math.Sin(x);
            //}
            //while (k-- >= 1);

            Console.WriteLine(s);
        }
    }
}
