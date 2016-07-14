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
           
            using (TextWriter tx = new StreamWriter("test.txt", true, Encoding.UTF8))
            {
                var author = obj.Authors.First();

                tx.WriteLine($"Was added new book: {DateTime.Now.Date}");
                tx.WriteLine($"\tAuthor: {author.FirstName} {author.LastName}");
                tx.WriteLine($"\tBook: {obj.Name}");
                tx.WriteLine($"\tDescription: {obj.Description}");
                tx.WriteLine($"\tPublication Year: {obj.PublicationDate.Year}");
            }
        }

        public string ReadFromFile(string pathOfFile)
        {
            StringBuilder currentLine = new StringBuilder();
            DirectoryInfo DirectoryInfo = new DirectoryInfo(@"E:\Projects\DelegatesAndEvents\DelegatesAndEvents\DelegatesAndEvents\bin\Debug");
            FileInfo[] fileInfo = DirectoryInfo.GetFiles("*.txt");
            var path = fileInfo.FirstOrDefault(f=>f.Name==pathOfFile).Name;

            if (path != string.Empty)
            {
                using (TextReader textReader = new StreamReader(path, Encoding.UTF8))
                {
                    currentLine.Append(textReader.ReadToEnd());
                }
            }
            return currentLine.ToString();
        }
    }
}
