using System;
namespace Template
{
    public class CharDisplay : AbstractDisplay
    {
        private char _char { get; }

        public CharDisplay(char ch)
        {
            _char = ch;
        }

        private protected override void Open()
        {
            Console.Write("<<");
        }

        private protected override void Print()
        {
            Console.Write(_char);
        }

        private protected override void Close()
        {
            Console.WriteLine(">>");
        }
    }
}
