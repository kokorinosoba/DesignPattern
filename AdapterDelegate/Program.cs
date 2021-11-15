using System;

namespace AdapterDelegate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Print print = new PrintBanner("Hello");
            print.PrintWeak();
            print.PrintStrong();
        }
    }
}

