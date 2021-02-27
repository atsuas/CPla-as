﻿using System;
using System.Collections.Generic;
using System.Linq;  // LINQを使うのに必要

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var nums = new int[] { 6, 4, 3, 2, 5, 1, 9, 8, 7, };
            var query = nums.OrderByDescending(x => x)
                            .Take(3);    //先頭の3つを取り出す
            foreach (var n in query)
            {
                Console.WriteLine(n);
            }
        }   
    }
}



