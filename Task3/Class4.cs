using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Content 
    {
        public string content = "Something";  
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(content);
        }
    }
}
