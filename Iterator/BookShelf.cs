using System;
using System.Collections.Generic;

namespace Iterator
{
    public class BookShelf : IAggregate
    {
        private readonly List<Book> _books;

        public BookShelf()
        {
            _books = new();
        }

        public Book GetBookAt(int index)
        {
            return _books[index];
        }

        public void AppendBook(Book book)
        {
            _books.Add(book);
        }

        public int GetLength()
        {
            return _books.Count;
        }

        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
