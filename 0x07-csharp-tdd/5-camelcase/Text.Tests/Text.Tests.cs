using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestNormalCase()
        {
            int result = Text.Str.CamelCase("thisIsASentance");
            Assert.AreEqual(result, 4);
        }

        [Test]
        public void TestNoCase()
        {
            int result = Text.Str.CamelCase("thisisasentance");
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void TestEmptyCase()
        {
            int result = Text.Str.CamelCase("");
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void TestAllCaps()
        {
            int result = Text.Str.CamelCase("ABBA");
            Assert.AreEqual(result, 4);
        }
    }
}