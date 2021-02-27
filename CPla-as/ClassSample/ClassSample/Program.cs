﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var employee = new Employee
            {
                Number = 368,
                FirstName = "ともや",
                LastName = "鈴木",
                HireDate = new DateTime(2016, 10, 3)
            };
            Console.WriteLine("従業員番号{0}の{1}は、{2}年に入社しました",
                employee.Number, employee.FullName, employee.HireDate.Year);
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
    }

    //従業員クラス
    class Employee : Person    //Personクラスを継承
    {
        //従業員番号
        public int Number { get; set; }
        //入社年月日
        public DateTime HireDate { get; set; }
    }

    //顧客クラス
    class Customer : Person
    {
        //顧客ID
        public string Id { get; set; }
        //顧客ランク
        public int Rank { get; set; }
        //クレジットカード番号
        public string CreditCardNumber { get; set; }
    }
}



