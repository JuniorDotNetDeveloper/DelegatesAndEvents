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
                new Book(authorList.Where(a => a.LastName == "Pushkin").First(), "Evgenii Onegin", new DateTime(1833)),
                new Book(authorList.Where(a => a.LastName == "Pushkin").First(), "Ruslan i Liudmila", new DateTime(1820)),
                new Book(authorList.Where(a => a.LastName == "Pushkin").First(), "Poltava", new DateTime(1829)),

                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Lev").First(), "Detstvo", new DateTime(1852)),
                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Lev").First(), "Iunosti", new DateTime(1864)),
                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Lev").First(), "Otrochestvo", new DateTime(1854)),

                new Book(authorList.Where(a => a.LastName == "Gorikii" & a.FirstName == "Maxin").First(), "Rasskazi staruha Izergili", new DateTime(1895)),
                new Book(authorList.Where(a => a.LastName == "Gorikii" & a.FirstName == "Maxin").First(), "Deti Solntsa", new DateTime(1905)),
                new Book(authorList.Where(a => a.LastName == "Gorikii" & a.FirstName == "Maxin").First(), "Vragi", new DateTime(1906)),

                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Alexei").First(), "Chiudaki", new DateTime(1911)),
                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Alexei").First(), "Hromoi Barin", new DateTime(1912)),
                new Book(authorList.Where(a => a.LastName == "Tolstoi" & a.FirstName == "Alexei").First(), "Emigranti", new DateTime(1931)),

                new Book(authorList.Where(a => a.LastName == "Gogoli").First(), "Vechera na hutore bliz Dikaniki", new DateTime(1831)),
                new Book(authorList.Where(a => a.LastName == "Gogoli").First(), "Revizor", new DateTime(1832)),
                new Book(authorList.Where(a => a.LastName == "Gogoli").First(), "Mertvie Dushi", new DateTime(1842)),

                new Book(authorList.Where(a => a.LastName == "Lermontov").First(), "Ispantsi", new DateTime(1830)),
                new Book(authorList.Where(a => a.LastName == "Lermontov").First(), "Tsigani", new DateTime(1828)),
                new Book(authorList.Where(a => a.LastName == "Lermontov").First(), "Dva Brata", new DateTime(1834)),

                new Book(authorList.Where(a => a.LastName == "Tiutchev" & a.FirstName == "Fedor").First(), "Nochnie Misli", new DateTime(1832)),
                new Book(authorList.Where(a => a.LastName == "Tiutchev" & a.FirstName == "Fedor").First(), "Kto hochet miru chiujdim biti...", new DateTime(1830)),
                new Book(authorList.Where(a => a.LastName == "Tiutchev" & a.FirstName == "Fedor").First(), "Privetsvie Duha", new DateTime(1827)),

                new Book(authorList.Where(a => a.LastName == "Turgenev" & a.FirstName == "Ivan").First(), "Asea", new DateTime(1857)),
                new Book(authorList.Where(a => a.LastName == "Turgenev" & a.FirstName == "Ivan").First(), "Dva Priatelea", new DateTime(1853)),
                new Book(authorList.Where(a => a.LastName == "Turgenev" & a.FirstName == "Ivan").First(), "Dim", new DateTime(1867)),

                new Book(authorList.Where(a => a.LastName == "Fet" & a.FirstName == "Afanasii").First(), "Talisman", new DateTime(1842)),
                new Book(authorList.Where(a => a.LastName == "Fet" & a.FirstName == "Afanasii").First(), "Student", new DateTime(1884)),

                new Book(authorList.Where(a => a.LastName == "Dostoevskii" & a.FirstName == "Fedor").First(), "Idiot", new DateTime(1874)),
                new Book(authorList.Where(a => a.LastName == "Dostoevskii" & a.FirstName == "Fedor").First(), "Igrok", new DateTime(1866)),
                new Book(authorList.Where(a => a.LastName == "Dostoevskii" & a.FirstName == "Fedor").First(), "Bratia Karamazovi", new DateTime(1880)),

                new Book(authorList.Where(a => a.LastName == "Maikov" & a.FirstName == "Appolon").First(), "Eho i Molchanie", new DateTime(1840)),
                new Book(authorList.Where(a => a.LastName == "Maikov" & a.FirstName == "Appolon").First(), "Ovidii", new DateTime(1841)),
                new Book(authorList.Where(a => a.LastName == "Maikov" & a.FirstName == "Appolon").First(), "Ia bil eshe ditea", new DateTime(1840)),

                new Book(authorList.Where(a => a.LastName == "Ostrovskii" & a.FirstName == "Alexandr").First(), "Groza", new DateTime(1859)),
                new Book(authorList.Where(a => a.LastName == "Ostrovskii" & a.FirstName == "Alexandr").First(), "Volki i Ovtsi", new DateTime(1875)),
                new Book(authorList.Where(a => a.LastName == "Ostrovskii" & a.FirstName == "Alexandr").First(), "Goriachee Serdtse", new DateTime(1868)),

                new Book(authorList.Where(a => a.LastName == "Saltikov-Shedrin" & a.FirstName == "Mihail").First(), "Jenih", new DateTime(1857)),
                new Book(authorList.Where(a => a.LastName == "Saltikov-Shedrin" & a.FirstName == "Mihail").First(), "Smerti Pazuhina", new DateTime(1859)),
                new Book(authorList.Where(a => a.LastName == "Saltikov-Shedrin" & a.FirstName == "Mihail").First(), "Teni", new DateTime(1863)),

                new Book(authorList.Where(a => a.LastName == "Leskov" & a.FirstName == "Nikolai").First(), "Smeh i Gore", new DateTime(1871)),
                new Book(authorList.Where(a => a.LastName == "Leskov" & a.FirstName == "Nikolai").First(), "Na Kraiu Sveta", new DateTime(1875)),
                new Book(authorList.Where(a => a.LastName == "Leskov" & a.FirstName == "Nikolai").First(), "Levsha", new DateTime(1881)),

                new Book(authorList.Where(a => a.LastName == "Uspenskii" & a.FirstName == "Gleb").First(), "Krokodil Gena i ego Druzia", new DateTime(1970)),
                new Book(authorList.Where(a => a.LastName == "Uspenskii" & a.FirstName == "Gleb").First(), "Diadia Fedor Kot i Peos", new DateTime(1974)),
                new Book(authorList.Where(a => a.LastName == "Uspenskii" & a.FirstName == "Gleb").First(), "Vot tak Shkola", new DateTime(1968))
            };


            

            Console.ReadLine();
        }
    }
}
