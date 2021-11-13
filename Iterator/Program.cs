using System;

namespace Iterator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BookShelf bookShelf = new(4);
            bookShelf.AppendBook(new("Around the Wrold in 80 Days"));
            bookShelf.AppendBook(new("Bible"));
            bookShelf.AppendBook(new("Cinderella"));
            bookShelf.AppendBook(new("Daddy-Long-Legs"));
            IIterator it = bookShelf.Iterator();
            while (it.HasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.GetName());
            }
        }
    }
}
