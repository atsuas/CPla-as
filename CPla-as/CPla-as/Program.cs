﻿using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var year = 1; year <= 64; year++)
            {
                var westernYear = year + 1925;
                Console.WriteLine($"昭和{year} {westernYear}年");
            }
        }
    }
}
