using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Collections.Generic;
using InventoryLibrary;
using InventoryManager;

namespace InventoryManagement.Tests
{
    public class BaseClassTests
    {
        [Test]
        public void TestInitBaseClass()
        {
            BaseClass newObj = new BaseClass();
            Assert.IsInstanceOf<string>(newObj.id);
            Assert.IsInstanceOf<DateTime>(newObj.date_created);
            Assert.IsInstanceOf<DateTime>(newObj.date_updated);
        }
    }
}
