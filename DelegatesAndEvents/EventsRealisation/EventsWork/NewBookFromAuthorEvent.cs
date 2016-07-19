using System;

namespace EventsRealisation.EventsWork
{
    class NewBookFromAuthorEvent
    {
        public event EventHandler<NewBookFromAuthorEvent> NewBook;
        
//        public void DoOnNewBook(Book book)
//        {
//                NewBook?.Invoke(this, book);
//        }
    }
}
