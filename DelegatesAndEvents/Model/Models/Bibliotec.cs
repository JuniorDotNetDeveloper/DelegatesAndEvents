using System;
using System.Net.Http.Headers;

namespace Model.Models
{
    class Bibliotec : Entity
    {
        public virtual Book AllBook { get; }
        public virtual Author AllAuthor{ get; }
        public virtual int BookCount { get; private set; }
        public virtual DateTime AddDate { get; } = DateTime.Now;


    }
}
