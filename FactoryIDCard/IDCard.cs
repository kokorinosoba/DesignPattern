using FactoryFramework;
using System;
namespace FactoryIDCard
{
    public class IDCard : Product
    {
        private string _owner { get; }

        public IDCard(string owner)
        {
            Console.WriteLine($"{owner}のカードを作ります。");
            _owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine($"{_owner}のカードを使います。");
        }

        public string GetOwner()
        {
            return _owner;
        }
    }
}
