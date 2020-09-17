using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class User
    {
         
        static string login = "log";

        static string name = "Vetol";

        static string surname = "Vetolisch";

        static int age = 13;

        readonly private static DateTime date;

        

        public void Show()
        {
            Console.WriteLine($"login: {login}\nname: {name}\nsurname: {surname}\nage: {age}\ndate: {date}");
        }

        static User()
        {
            date = DateTime.Now;
        }
    }

}

