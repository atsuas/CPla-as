﻿using System;
using System.IO;    //Fileクラスを使用する際に必要

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new string[]
            {
                "あああああああああああ",
                "いいいいいいいいいいいい",
                "うううううううううううううう",
                "ええええええええええええええええ"
            };
            File.WriteAllLines(@"C:\\temp\\ああああ.txt", lines);
        }
    }
}




