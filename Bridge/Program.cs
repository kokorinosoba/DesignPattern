using System;

namespace Bridge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Display d1 = new(new StringDisplay("Hello, Japan."));
            Display d2 = new CountDisplay(new StringDisplay("Hello, World."));
            CountDisplay d3 = new(new StringDisplay("Hello, Universe."));

            d1.Displays();
            d2.Displays();
            d3.MultiDisplay(5);
        }
    }
}

