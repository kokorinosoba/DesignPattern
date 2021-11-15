using System;
namespace Template
{
    public abstract class AbstractDisplay
    {
        private protected abstract void Open();
        private protected abstract void Print();
        private protected abstract void Close();

        public void Display()
        {
            Open();
            for (int i = 0; i < 5; i++)
            {
                Print();
            }

            Close();
        }
    }
}
