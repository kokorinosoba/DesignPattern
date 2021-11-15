using Adapter;
using System;
namespace AdapterDelegate
{
    public class PrintBanner : Print
    {
        private Banner _banner { get; }

        public PrintBanner(string str)
        {
            _banner = new(str);
        }

        public override void PrintWeak()
        {
            _banner.ShowWithParen();
        }

        public override void PrintStrong()
        {
            _banner.ShowWithAster();
        }
    }
}
