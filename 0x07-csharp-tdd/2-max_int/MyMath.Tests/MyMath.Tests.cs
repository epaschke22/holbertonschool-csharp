using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestPositiveList()
        {
            var input = new List<int> {1,2,3,10,5};
            int result = MyMath.Operations.Max(input);
            Assert.AreEqual(result, 10);
        }

        [Test]
        public void TestNegativeList()
        {
            var input = new List<int> {-4,-2,-5};
            int result = MyMath.Operations.Max(input);
            Assert.AreEqual(result, -2);
        }

        [Test]
        public void TestEmptyList()
        {
            var input = new List<int> {};
            int result = MyMath.Operations.Max(input);
            Assert.AreEqual(result, 0);
        }
    }
}
