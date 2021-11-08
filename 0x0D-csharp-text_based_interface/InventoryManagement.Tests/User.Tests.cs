using NUnit.Framework;
using System;
using System.Collections.Generic;
using InventoryLibrary;
using InventoryManager;

namespace InventoryManagement.Tests
{
    public class UserClassTests
    {
        [Test]
        public void TestInitUserClass()
        {
            User newObj = new User();
            Assert.IsInstanceOf<string>(newObj.id);
            Assert.IsInstanceOf<DateTime>(newObj.date_created);
            Assert.IsInstanceOf<DateTime>(newObj.date_updated);
            Assert.IsInstanceOf<string>(newObj.name);
        }
    }
}
