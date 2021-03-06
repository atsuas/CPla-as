﻿using System;
using System.IO;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            try
            {
                ReadSample();
            }
            catch
            {
                Console.WriteLine("ReadSampleでエラーが発生");
            }
        }

        private static void ReadSample()
        {
            using (var file = new StreamReader("test.txt"))
            {
                while (file.EndOfStream == false)
                {
                    var line = file.ReadLine();
                    Console.WriteLine(line);
                }
            }   //Disposeメソッドは書かれていないが、最後にfile.Disaposeが呼ばれる
        }
    }
}



