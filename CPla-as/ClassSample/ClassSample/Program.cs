﻿using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "たかし",
                LastName = "小林"
            };
            var name1 = person.AddTitle("先生");  //引数を指定して呼び出す
            var name2 = person.AddTitle();  //引数を省略して呼び出す
            Console.WriteLine(name1);
            Console.WriteLine(name2);
        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string AddTitle(string title = "様")  //titleは省力可能な引数
            {
                return $"{LastName}{FirstName} {title}";
            }
           
        }
    }
}




