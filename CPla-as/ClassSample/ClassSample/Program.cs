﻿using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2020, 11, 7);
            var year = date.Year;
            var month = date.Month;
            var day = date.Day;
            Console.WriteLine("{0}年{1}月{2}日", year, month, date);
        }
    }
}




