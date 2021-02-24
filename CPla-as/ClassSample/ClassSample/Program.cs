﻿using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new int[] { 46, 59, 48, 93, 29, 20, 70 };
            var total = ArrayUtils.Total(scores);   //静的メソッドの呼び出し
            var average = ArrayUtils.Average(scores);   //静的メソッドの呼び出し
            Console.WriteLine($"合計:{total}, 平均:{average}");
        }
    }

    static class ArrayUtils //staticメソッドで静的クラスにする
    {
        public static int Total(int[] numbers)  //配列内の数値の合計を求める
        {
            var total = 0;
            foreach (var n in numbers)
            {
                total += n;
            }
            return total;
        }

        public static double Average(int[] numbers)
        {
            var total = Total(numbers); //上記のTotalメソッドを呼び出す
            return (int)total / numbers.Length;
        }
    }
}




