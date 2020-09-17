using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            book.author = Console.ReadLine();
            book.title = Console.ReadLine();
            book.content = Console.ReadLine();
            

            Title title = new Title();
            title.Show();
            Author author = new Author();
            author.Show();
            Content content = new Content();
            content.Show();
        }
        
    }
}
