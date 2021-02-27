using System;
using System.Collections.Generic;
using System.Linq;  // LINQを使うのに必要

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var nums = new List<int> { 12, 69, 38, 32, 63, 55, 71, 93, 39, 48 };

            var query = nums.Where(x => x >= 50);   //Whereは条件に一致した要素を抜き出す
            foreach (var n in query)
            {
                Console.WriteLine(n);
            }
        }   
    }
}



