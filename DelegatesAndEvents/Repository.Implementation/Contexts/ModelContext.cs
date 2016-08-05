using System.Collections.Generic;
using System.Data.Entity;
using Model.Models;

namespace Repository.Implementation.Contexts
{
    public class ModelContext<T> 
        where T : Entity
    {
        public List<T> Objects { get; set; }
    }
}