using NUnit.Framework;
using System;
using System.Collections.Generic;
using InventoryLibrary;
using InventoryManager;

namespace InventoryManagement.Tests
{
    public class ItemClassTests
    {
        [Test]
        public void TestInitItemClass()
        {
            Item newObj = new Item();
            Assert.IsInstanceOf<string>(newObj.id);
            Assert.IsInstanceOf<DateTime>(newObj.date_created);
            Assert.IsInstanceOf<DateTime>(newObj.date_updated);
            Assert.IsInstanceOf<string>(newObj.name);
            Assert.IsInstanceOf<string>(newObj.description);
            Assert.IsInstanceOf<float>(newObj.price);
        }
    }
}
