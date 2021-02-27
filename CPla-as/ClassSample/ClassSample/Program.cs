﻿using System;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var book = GetBook();   //nullかどうかでGetBookが成功したかどうかを判断
            if (book == null)
            {
                Console.WriteLine("bookオブジェクトは生成できませんでした");
            }
            else
            {
                Console.WriteLine($"{book.Title} {book.Auther}");
            }
        }
        private static Book GetBook()
        {
            var line = Console.ReadLine();
            var items = line.Split(',');
            if (items.Length != 2)
            {
                return null;    //入力したデータが正しくない場合はnullを返す
            }
            var book = new Book
            {
                Title = items[0],
                Auther = items[1],
            };
            return book;
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

    }
}



