﻿using System;
using System.Collections.Generic;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var books = new List<Book>();   //Book型のリストを生成
            var book1 = new Book("吾輩は猫である", "夏目漱石", 620, 4);
            books.Add(book1);   //1冊目を追加
            var book2 = new Book("人間失格", "太宰治", 300, 5);
            books.Add(book2);   //2冊目を追加

            //省略もできる
            //books.Add(new Book("吾輩は猫である", "夏目漱石", 620, 4));
            //books.Add(new Book("人間失格", "太宰治", 300, 5));

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} {book.Auther} {book.Pages} {book.Rating}");
            }
        }   
    }

    class Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        public Book(string title, string auther, int pages, int rating)
        {
            Title = title;
            Auther = auther;
            Pages = pages;
            Rating = rating;
        }
    }
}



