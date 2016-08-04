using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Model.Models;
using Repository.Implementation.Contexts;
using IRepository.Interfaces;

namespace Repository.Implementation
{
    public class AuthorRepository : IRepository<Author>
    {
        private readonly ModelContext<Author> _authorRepository;
        private string _connection = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        public AuthorRepository()
        {
            _authorRepository = new ModelContext<Author>();
            Initializer();
        }
        public IEnumerable<Author> Collection { get { return  _authorRepository.Objects.ToList(); } }
        public void Create(Author item)
        {
            _authorRepository.Objects.Add(item);
        }

        public void Update(Author item)
        {
            using (var sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();
                var sqlUpdateQuery = "Update Author SET Description = @authorDescription where Id = 1";
                var sqlCommand = new SqlCommand(sqlUpdateQuery, sqlConnection);
                sqlCommand.ExecuteScalar();
            }
        }



        public void Delete(int id)
        {
            var author = _authorRepository.Objects.Find(a => a.Id == id);
            _authorRepository.Objects.Remove(author);
        }

        public Author FindById(int id)
        {
            return _authorRepository.Objects.Find(a => a.Id == id);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }



        private void Initializer()
        {

            using (var sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();
                string createTable = "create table NewTestTable(Id bigint identity(1,1), FirstName nvarchar(100) not null, LastName nvarchar(100) not null)";
                var sqlCommand = new SqlCommand(createTable, sqlConnection);

                using (sqlCommand)
                {
                    sqlCommand.ExecuteNonQuery();
                }

            }

            //List<Author> authorList = new List<Author>()
            //{
            //    new Author("Alexandr", "Pushkin"),
            //    new Author("Lev", "Tolstoi"),
            //    new Author("Maxin", "Gorikii"),
            //    new Author("Alexei", "Tolstoi"),
            //    new Author("Nikolai", "Gogoli"),
            //    new Author("Mihail", "Lermontov"),
            //    new Author("Fedor", "Tiutchev"),
            //    new Author("Ivan", "Turgenev"),
            //    new Author("Afanasii", "Fet"),
            //    new Author("Fedor", "Dostoevskii"),
            //    new Author("Appolon", "Maikov"),
            //    new Author("Alexandr", "Ostrovskii"),
            //    new Author("Mihail", "Saltikov-Shedrin"),
            //    new Author("Nikolai", "Leskov"),
            //    new Author("Gleb", "Uspenskii"),
            //    new Author("NoBook", "Author")
            //};
            //_authorRepository.Objects = authorList;
        }
    }
}
