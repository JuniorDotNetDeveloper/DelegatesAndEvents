﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Factory.Factories;
using IRepository.Interfaces;
using Model.Models;
using Repository.Implementation.Contexts;

namespace Repository.Implementation
{
    public class BookRepository : IRepository<Book>
    {
        private readonly ModelContext<Book> _bookRepository;
        private BookFactory bookFactory = new BookFactory();

        public IEnumerable<Book> Collection
        {
            get { return _bookRepository.Objects.ToList(); }
        }

        public BookRepository()
        {
            _bookRepository = new ModelContext<Book>();
            Initializer();
        }

        public void Create(Book item)
        {
            if (item != null)
                _bookRepository.Objects.Add(item);
        }

        public void Update(Book item)
        {
            _bookRepository.Objects.Where(w => w == item).Select(w => w.Description = item.Description);
        }

        public void Delete(int id)
        {
            var book = _bookRepository.Objects.Find(b=>b.Id == id);
            if (book != null)
                _bookRepository.Objects.Remove(book);
        }

        public Book FindById(int id)
        {
            if (id != 0)
                return _bookRepository.Objects.FirstOrDefault(b => b.Id == id);
            throw new ArgumentNullException($"Id: {id} is null");
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        private void Initializer()
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
                new Author("Gleb", "Uspenskii"),
                new Author("NoBook", "Author")
            };
            _bookRepository.Objects = new List<Book>()
            {
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Pushkin"), "Poltava", new DateTime(1829,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Pushkin"), "Evgenii Onegin", new DateTime(1833, 12,12)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Pushkin"), "Ruslan i Liudmila", new DateTime(1820,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Pushkin"), "Poltava", new DateTime(1829,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Tolstoi" & a.FirstName == "Lev"), "Detstvo", new DateTime(1852,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Tolstoi" & a.FirstName == "Lev"), "Iunosti", new DateTime(1864,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Tolstoi" & a.FirstName == "Lev"), "Otrochestvo", new DateTime(1854,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Gorikii" & a.FirstName == "Maxin"), "Rasskazi staruha Izergili", new DateTime(1895,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Gorikii" & a.FirstName == "Maxin"), "Deti Solntsa", new DateTime(1905,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Gorikii" & a.FirstName == "Maxin"), "Vragi", new DateTime(1906,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Tolstoi" & a.FirstName == "Alexei"), "Chiudaki", new DateTime(1911,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Tolstoi" & a.FirstName == "Alexei"), "Hromoi Barin", new DateTime(1912,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Tolstoi" & a.FirstName == "Alexei"), "Emigranti", new DateTime(1931,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Gogoli"), "Vechera na hutore bliz Dikaniki", new DateTime(1831,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Gogoli"), "Revizor", new DateTime(1832,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Gogoli"), "Mertvie Dushi", new DateTime(1842,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Lermontov"), "Ispantsi", new DateTime(1830,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Lermontov"), "Tsigani", new DateTime(1828,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Lermontov"), "Dva Brata", new DateTime(1834,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Tiutchev" & a.FirstName == "Fedor"), "Nochnie Misli", new DateTime(1832,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Tiutchev" & a.FirstName == "Fedor"), "Kto hochet miru chiujdim biti...", new DateTime(1830,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Tiutchev" & a.FirstName == "Fedor"), "Privetsvie Duha", new DateTime(1827,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Turgenev" & a.FirstName == "Ivan"), "Asea", new DateTime(1857,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Turgenev" & a.FirstName == "Ivan"), "Dva Priatelea", new DateTime(1853,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Turgenev" & a.FirstName == "Ivan"), "Dim", new DateTime(1867,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Fet" & a.FirstName == "Afanasii"), "Talisman", new DateTime(1842,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Fet" & a.FirstName == "Afanasii"), "Student", new DateTime(1884,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Dostoevskii" & a.FirstName == "Fedor"), "Idiot", new DateTime(1874,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Dostoevskii" & a.FirstName == "Fedor"), "Igrok", new DateTime(1866,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Dostoevskii" & a.FirstName == "Fedor"), "Bratia Karamazovi", new DateTime(1880,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Maikov" & a.FirstName == "Appolon"), "Eho i Molchanie", new DateTime(1840,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Maikov" & a.FirstName == "Appolon"), "Ovidii", new DateTime(1841,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Maikov" & a.FirstName == "Appolon"), "Ia bil eshe ditea", new DateTime(1840,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Ostrovskii" & a.FirstName == "Alexandr"), "Groza", new DateTime(1859,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Ostrovskii" & a.FirstName == "Alexandr"), "Volki i Ovtsi", new DateTime(1875,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Ostrovskii" & a.FirstName == "Alexandr"), "Goriachee Serdtse", new DateTime(1868,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Saltikov-Shedrin" & a.FirstName == "Mihail"), "Jenih", new DateTime(1857,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Saltikov-Shedrin" & a.FirstName == "Mihail"), "Smerti Pazuhina", new DateTime(1859,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Saltikov-Shedrin" & a.FirstName == "Mihail"), "Teni", new DateTime(1863,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Leskov" & a.FirstName == "Nikolai"), "Smeh i Gore", new DateTime(1871,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Leskov" & a.FirstName == "Nikolai"), "Na Kraiu Sveta", new DateTime(1875,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Leskov" & a.FirstName == "Nikolai"), "Levsha", new DateTime(1881,01,01)),

                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Uspenskii" & a.FirstName == "Gleb"), "Krokodil Gena i ego Druzia", new DateTime(1970,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Uspenskii" & a.FirstName == "Gleb"), "Diadia Fedor Kot i Peos", new DateTime(1974,01,01)),
                bookFactory.CreateNewBook_WithSingleAuthor(authorList.First(a => a.LastName == "Uspenskii" & a.FirstName == "Gleb"), "Vot tak Shkola", new DateTime(1968,01,01))
            };
        }
    }
}
