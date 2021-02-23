using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = 1;
            while (year <= 64)
            {
                var westernYear = year + 1925;
                Console.WriteLine($"昭和{year}年 {westernYear}年");
                year += 1;
            }
        }
    }
}
