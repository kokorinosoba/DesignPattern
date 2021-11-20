using System;
using System.Text;

namespace Bridge
{
    public class StringDisplay : DisplayImpl
    {
        private string _string { get; }
        private int _width { get; }

        public StringDisplay(string str)
        {
            _string = str;
            _width = Encoding.GetEncoding("Shift-JIS").GetByteCount(str);
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine($"|{_string}|");
        }

        public override void RawClose()
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
