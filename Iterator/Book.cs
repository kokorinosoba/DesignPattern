using System;
namespace Iterator
{
    public class Book
    {
        private string _name { get; }
        public Book(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
