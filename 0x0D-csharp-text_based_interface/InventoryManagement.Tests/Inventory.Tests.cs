using NUnit.Framework;
using System;
using System.Collections.Generic;
using InventoryLibrary;
using InventoryManager;

namespace InventoryManagement.Tests
{
    public class InventoryClassTests
    {
        [Test]
        public void TestInitInventorClass()
        {
            Inventory newObj = new Inventory();
            Assert.IsInstanceOf<string>(newObj.id);
            Assert.IsInstanceOf<DateTime>(newObj.date_created);
            Assert.IsInstanceOf<DateTime>(newObj.date_updated);
            Assert.IsInstanceOf<string>(newObj.user_id);
            Assert.IsInstanceOf<string>(newObj.item_id);
            Assert.IsInstanceOf<int>(newObj.quantity);
        }
    }
}
