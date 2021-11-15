using System;

namespace Template
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, World.");
            AbstractDisplay d3 = new StringDisplay("こんにちは。");

            AbstractDisplay[] ds = new[] { d1, d2, d3 };
            foreach (AbstractDisplay d in ds)
            {
                d.Display();
            }
        }
    }
}

