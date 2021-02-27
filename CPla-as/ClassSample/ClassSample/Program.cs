﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            //呼び出し
            var employee = new Employee()
            {
                Number = 368,
                FirstName = "ともや",
                LastName = "鈴木",
                Email = "tomotomo@example.com",
                HireDate = new DateTime(2016, 10, 3)
            };
            var s = employee.ToString();    //オーバーライドしたToStringメソッドを呼び出す
            Console.WriteLine(s);

            var person = new Person
            {
                FirstName = "ゆか",
                LastName = "佐々木",
                Email = "sasasa@example.com"
            };
            person.Print();
        }   
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return LastName + FirstName; }
        }
        public string Email { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"名前: {FullName} ({Email})");
        }
    }

    class Employee : Person
    {
        public int Number { get; set; }
        public DateTime HireDate { get; set; }

        public override string ToString()   //ToStringメソッドをオーバーライド
        {
            var s = $"{Number} {FullName} " + $"{HireDate.Year}年{HireDate.Month}月{HireDate.Day}日入社";
            return s;
        }
    }

    class Customer : Person
    {
        public string Id { get; set; }
        public int Rank { get; set; }
        public string CreditCardNumber { get; set; }
    }
}



