﻿using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today; //Todayは静的プロパティ、todayはDateTime型
            Console.WriteLine($"{today.Year}年{today.Month}月{today.Day}日");
        }
    }
}




