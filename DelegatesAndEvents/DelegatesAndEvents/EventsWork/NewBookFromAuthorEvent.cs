using DelegatesAndEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.EventsWork
{
    class NewBookFromAuthorEvent
    {
        public event EventHandler<Book> NewBook;
        
        public void DoOnNewBook(Book book)
        {
            if (NewBook != null)
            {
                NewBook(this, book);
            }
        }
    }
}
