using System;
namespace Bridge
{
    public class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl impl) : base(impl)
        {
        }

        public void MultiDisplay(int time)
        {
            Open();
            for (int i = 0; i < time; i++)
            {
                Print();
            }

            Close();
        }
    }
}
