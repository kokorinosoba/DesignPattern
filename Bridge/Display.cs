using System;
namespace Bridge
{
    public class Display
    {
        private DisplayImpl _impl { get; }

        public Display(DisplayImpl impl)
        {
            _impl = impl;
        }

        private protected void Open()
        {
            _impl.RawOpen();
        }

        private protected void Print()
        {
            _impl.RawPrint();
        }

        private protected void Close()
        {
            _impl.RawClose();
        }

        public void Displays()
        {
            Open();
            Print();
            Close();
        }
    }
}
