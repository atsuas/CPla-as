using System;
using System.Collections.Generic;
using System.Linq;  // LINQを使うのに必要

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var nums = new int[] { 62, 4, 34, 26, 15, 51, 97, 84, 72, };
            var list = nums.Where(x => x <= 10)
                            .ToList();    //Whereの結果をList<int>に変換する
            Console.WriteLine(list[0]);
        }   
    }
}



