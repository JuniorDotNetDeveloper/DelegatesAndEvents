using DelegatesAndEvents.EventsWork;
using DelegatesAndEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region define author and book lists 
            List<Author> authorList = new List<Author>()
            {
                new Author("Alexandr", "Pushkin"),
                new Author("Lev", "Tolstoi"),
                new Author("Maxin", "Gorikii"),
                new Author("Alexei", "Tolstoi"),
                new Author("Nikolai", "Gogoli"),
                new Author("Mihail", "Lermontov"),
                new Author("Fedor", "Tiutchev"),
                new Author("Ivan", "Turgenev"),
                new Author("Afanasii", "Fet"),
                new Author("Fedor", "Dostoevskii"),
                new Author("Appolon", "Maikov"),
                new Author("Alexandr", "Ostrovskii"),
                new Author("Mihail", "Saltikov-Shedrin"),
                new Author("Nikolai", "Leskov"),
                new Author("Gleb", "Uspenskii")
            };

            List<Book> bookList = new List<Book>()
            {
                new Book(authorList.Where(a => a.LastName == "Pushkin").First(), "Evgenii Onegin", (1833)),
                new Book(authorList.Where(a => a.LastName == "Pushkin").First(), "Ruslan i Liudmila", (1820)),
                new Book(authorList.Where(a => a.LastName == "Pushkin").First(), "Poltava", (1829)),

                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Lev").First(), "Detstvo", (1852)),
                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Lev").First(), "Iunosti", (1864)),
                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Lev").First(), "Otrochestvo", (1854)),

                new Book(authorList.Where(a => a.LastName == "Gorikii" & a.FirstName == "Maxin").First(), "Rasskazi staruha Izergili", (1895)),
                new Book(authorList.Where(a => a.LastName == "Gorikii" & a.FirstName == "Maxin").First(), "Deti Solntsa", (1905)),
                new Book(authorList.Where(a => a.LastName == "Gorikii" & a.FirstName == "Maxin").First(), "Vragi", (1906)),

                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Alexei").First(), "Chiudaki", (1911)),
                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Alexei").First(), "Hromoi Barin", (1912)),
                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Alexei").First(), "Emigranti", (1931)),

                new Book(authorList.Where(a => a.LastName == "Gogoli").First(), "Vechera na hutore bliz Dikaniki", (1831)),
                new Book(authorList.Where(a => a.LastName == "Gogoli").First(), "Revizor", (1832)),
                new Book(authorList.Where(a => a.LastName == "Gogoli").First(), "Mertvie Dushi", (1842)),

                new Book(authorList.Where(a => a.LastName == "Lermontov").First(), "Ispantsi", (1830)),
                new Book(authorList.Where(a => a.LastName == "Lermontov").First(), "Tsigani", (1828)),
                new Book(authorList.Where(a => a.LastName == "Lermontov").First(), "Dva Brata", (1834)),

                new Book(authorList.Where(a => a.LastName == "Tiutchev" & a.FirstName == "Fedor").First(), "Nochnie Misli", (1832)),
                new Book(authorList.Where(a => a.LastName == "Tiutchev" & a.FirstName == "Fedor").First(), "Kto hochet miru chiujdim biti...", (1830)),
                new Book(authorList.Where(a => a.LastName == "Tiutchev" & a.FirstName == "Fedor").First(), "Privetsvie Duha", (1827)),

                new Book(authorList.Where(a => a.LastName == "Turgenev" & a.FirstName == "Ivan").First(), "Asea", (1857)),
                new Book(authorList.Where(a => a.LastName == "Turgenev" & a.FirstName == "Ivan").First(), "Dva Priatelea", (1853)),
                new Book(authorList.Where(a => a.LastName == "Turgenev" & a.FirstName == "Ivan").First(), "Dim", (1867)),

                new Book(authorList.Where(a => a.LastName == "Fet" & a.FirstName == "Afanasii").First(), "Talisman", (1842)),
                new Book(authorList.Where(a => a.LastName == "Fet" & a.FirstName == "Afanasii").First(), "Student", (1884)),

                new Book(authorList.Where(a => a.LastName == "Dostoevskii" & a.FirstName == "Fedor").First(), "Idiot", (1874)),
                new Book(authorList.Where(a => a.LastName == "Dostoevskii" & a.FirstName == "Fedor").First(), "Igrok", (1866)),
                new Book(authorList.Where(a => a.LastName == "Dostoevskii" & a.FirstName == "Fedor").First(), "Bratia Karamazovi", (1880)),

                new Book(authorList.Where(a => a.LastName == "Maikov" & a.FirstName == "Appolon").First(), "Eho i Molchanie", (1840)),
                new Book(authorList.Where(a => a.LastName == "Maikov" & a.FirstName == "Appolon").First(), "Ovidii", (1841)),
                new Book(authorList.Where(a => a.LastName == "Maikov" & a.FirstName == "Appolon").First(), "Ia bil eshe ditea", (1840)),

                new Book(authorList.Where(a => a.LastName == "Ostrovskii" & a.FirstName == "Alexandr").First(), "Groza", (1859)),
                new Book(authorList.Where(a => a.LastName == "Ostrovskii" & a.FirstName == "Alexandr").First(), "Volki i Ovtsi", (1875)),
                new Book(authorList.Where(a => a.LastName == "Ostrovskii" & a.FirstName == "Alexandr").First(), "Goriachee Serdtse", (1868)),

                new Book(authorList.Where(a => a.LastName == "Saltikov-Shedrin" & a.FirstName == "Mihail").First(), "Jenih", (1857)),
                new Book(authorList.Where(a => a.LastName == "Saltikov-Shedrin" & a.FirstName == "Mihail").First(), "Smerti Pazuhina", (1859)),
                new Book(authorList.Where(a => a.LastName == "Saltikov-Shedrin" & a.FirstName == "Mihail").First(), "Teni", (1863)),

                new Book(authorList.Where(a => a.LastName == "Leskov" & a.FirstName == "Nikolai").First(), "Smeh i Gore", (1871)),
                new Book(authorList.Where(a => a.LastName == "Leskov" & a.FirstName == "Nikolai").First(), "Na Kraiu Sveta", (1875)),
                new Book(authorList.Where(a => a.LastName == "Leskov" & a.FirstName == "Nikolai").First(), "Levsha", (1881)),

                new Book(authorList.Where(a => a.LastName == "Uspenskii" & a.FirstName == "Gleb").First(), "Krokodil Gena i ego Druzia", (1970)),
                new Book(authorList.Where(a => a.LastName == "Uspenskii" & a.FirstName == "Gleb").First(), "Diadia Fedor Kot i Peos", (1974)),
                new Book(authorList.Where(a => a.LastName == "Uspenskii" & a.FirstName == "Gleb").First(), "Vot tak Shkola", (1968))
            };

            #endregion

            #region Filtering

            var after1900Year = bookList.Where(b => b.PublicationYear > 1900).Select(b=>b.PublicationYear);
            foreach (var item in after1900Year)
            {
                Console.WriteLine(item);
            }
            
            //var dostoevskii = bookList.Where(a => a.Authors.Where(a2 => a2.FirstName == "Fedor" && a2.LastName == "Dostoevskii") == a);
            var d = from book in bookList
                    select new { author = book.Authors.Distinct().First(), books = book.Name }
                    into g
                    group g.books by g.author;
                    //select new { BookName = g.ToList() };

            foreach (var item in d)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
                Console.WriteLine(item);
                //Console.WriteLine(item.author);
                //Console.WriteLine(item.books);
                   
            }
            #endregion
            Console.ReadLine();
        }
    }
}
