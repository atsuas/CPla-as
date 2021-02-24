﻿using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Print12Hour(5);
            Print12Hour(18);
            Print12Hour(25);
        }

        static void Print12Hour(int hour)
        {
            if (hour < 0 || 24 < hour)
            {
                Console.WriteLine("正しい値ではありません");
                return;
            }
            if (hour <= 12)
            {
                Console.WriteLine("午前{0}時です", hour);
            }
            else
            {
                Console.WriteLine("午後{0}時です", hour - 12);
            }
        }
    }
}




