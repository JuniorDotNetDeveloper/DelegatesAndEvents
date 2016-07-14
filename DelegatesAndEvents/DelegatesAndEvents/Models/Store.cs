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
        
        public IList<Book> BooksInStore { get;  } = new List<Book>();
        public IList<Author> AuthorsInStore { get; } = new List<Author>();

        public void ExtendStoreLists(object sender, EventArguments<Book> newBook)
        {
            if (newBook._Object == null) throw new ArgumentNullException($"EventArg: {nameof(newBook._Object)} is null ");
            BooksInStore.Add(newBook._Object);
            WriteInFile(newBook._Object);
            Console.WriteLine("New book added");
        }

        public void ExtendStoreLists(object sender, EventArguments<Author> newAuthor)
        {
            if (newAuthor._Object == null) throw new ArgumentNullException($"EventArg: {nameof(newAuthor._Object)} is null ");
            AuthorsInStore.Add(newAuthor._Object);
            Console.WriteLine("new author added");
        }

        private void WriteInFile(Book obj)
        {

            using (TextWriter tx = new StreamWriter("test.txt", true))
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
