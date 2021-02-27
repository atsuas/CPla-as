using System;
using System.Collections.Generic;
using System.Linq;  // LINQを使うのに必要

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var words = new List<string>
            {
                "effect", "access", "condition", "sign", "profit", "line", "result"
            };
            var query = words.Where(x => x.Length == 6);    //長さ6の文字列だけ取り出す
            foreach (var word in query)
            {
                Console.WriteLine(word);
            }
        }   
    }
}



