using System;
using System.Text;

namespace Template
{
    public class StringDisplay : AbstractDisplay
    {
        private string _string { get; }
        private int _width { get; }

        public StringDisplay(string str)
        {
            _string = str;
            _width = Encoding.GetEncoding("Shift-JIS").GetByteCount(str);
        }

        private protected override void Open()
        {
            PrintLine();
        }

        private protected override void Print()
        {
            Console.WriteLine($"|{_string}|");
        }

        private protected override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write('+');
            for (int i = 0; i < _width; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine("+");
        }
    }
}
