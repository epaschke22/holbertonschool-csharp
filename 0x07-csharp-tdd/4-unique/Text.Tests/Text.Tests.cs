using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestUnique()
        {
            int result = Text.Str.UniqueChar("aaaaahhh");
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void TestSingleChar()
        {
            int result = Text.Str.UniqueChar("a");
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void TestEmptyString()
        {
            int result = Text.Str.UniqueChar("");
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void TestRepeatingChar()
        {
            int result = Text.Str.UniqueChar("aaaaa");
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void TestRegularWord()
        {
            int result = Text.Str.UniqueChar("hello");
            Assert.AreEqual(result, 0);
        }
    }
}