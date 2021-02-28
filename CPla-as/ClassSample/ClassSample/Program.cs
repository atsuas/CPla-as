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
            var file = new StreamReader("test.txt");
            try
            {
                while (file.EndOfStream == false)
                {
                    var line = file.ReadLine();
                    Console.WriteLine(line);
                }
            }
            finally
            {
                file.Dispose();
            }
        }
    }
}



