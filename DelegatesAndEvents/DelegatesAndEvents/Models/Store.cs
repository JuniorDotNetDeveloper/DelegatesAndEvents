using DelegatesAndEvents.EventsWork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Models
{
    internal class Store
    {
        public IList<Book> BooksInStore { get; set; }
        public IList<Author> AuthorsInStore { get; set; }

        public Store(NewBookFromAuthorEvent e)
        {
            BooksInStore = new List<Book>();
            AuthorsInStore = new List<Author>();
            e.NewBook += ExtendStoreLists;   
        }

        
        public void ExtendStoreLists(object sender, Book newBook)
        {
            BooksInStore.Add(newBook);
            WriteInFile(newBook);
            Console.WriteLine("New book added");

        }
        public void ExtendStoreLists(Author newAuthor)
        {
            AuthorsInStore.Add(newAuthor);
            Console.WriteLine("new author added");
        }

        private void WriteInFile(Book obj)
        {
            Stream fs = new FileStream("test.txt", FileMode.Append);
            using (fs)
            using (TextWriter tx = new StreamWriter(fs))
            {
                var author = obj.Authors.First();

                tx.WriteLine($"Was added new book: {DateTime.Now.Date}");
                tx.WriteLine($"\tAuthor: {author.FirstName} {author.LastName}");
                tx.WriteLine($"\tBook: {obj.Name}");
                tx.WriteLine($"\tDescription: {obj.Description}");
                tx.WriteLine($"\tPublication Year: {obj.PublicationDate.Year}");
            }
        }

    }
}
