using System;
using System.Collections.Generic;

namespace EFCoreConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SaveBooksandAuthor();
            using (var context = new EFCoreDemoContext())
            {
                foreach (var book in context.Books)
                {
                    Console. WriteLine(book.Title);
                }
            }
            // Console.WriteLine("Hello World!");
        }
        static void SaveBooksandAuthor()
        {
            using (var context = new EFCoreDemoContext())
            {
                var author = new Author
                {
                    FirstName = "William",
                    LastName = "Shakespeare",
                    Books = new List<Book>
                    {
                        new Book { Title = "Hamlet"},
                        new Book { Title = "Othello" },
                        new Book { Title = "MacBeth" }
                    }
                };
                context.Add(author);
                context.SaveChanges();
            }

        }
    }
}
