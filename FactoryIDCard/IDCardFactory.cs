using FactoryFramework;
using System;
using System.Collections.Generic;

namespace FactoryIDCard
{
    public class IDCardFactory : Factory
    {
        private readonly List<string> _owners = new();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            _owners.Add(((IDCard)product).GetOwner());
        }

        public List<string> GetOwners()
        {
            return _owners;
        }
    }
}
