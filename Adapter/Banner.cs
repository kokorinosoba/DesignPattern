using System;
namespace Adapter
{
    public class Banner
    {
        private string _string { get; }

        public Banner(string str)
        {
            _string = str;
        }

        public void ShowWithParen()
        {
            Console.WriteLine($"({_string})");
        }

        public void ShowWithAster()
        {
            Console.WriteLine($"*{_string}*");
        }
    }
}
