using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Title 
    {
        public string title = "War and Peace";
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(title);
        }
    }
}
