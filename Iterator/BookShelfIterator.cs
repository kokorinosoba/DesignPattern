using System;
namespace Iterator
{
    public class BookShelfIterator : IIterator
    {
        private readonly BookShelf _bookShelf;
        private int _index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
            _index = 0;
        }

        public bool HasNext()
        {
            return _index < _bookShelf.GetLength();
        }

        public object Next()
        {
            return _bookShelf.GetBookAt(_index++);
        }
    }
}
