using System;

namespace Adapter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IPrint print = new PrintBanner("Hello");
            print.PrintWeak();
            print.PrintStrong();
        }
    }
}

