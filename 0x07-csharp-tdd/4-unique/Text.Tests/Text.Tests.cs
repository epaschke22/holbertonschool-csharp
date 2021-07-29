using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestUnique()
        {
            int result = Text.Str.UniqueChar("aaahaaa");
            Assert.AreEqual(result, 3);
            int result = Text.Str.UniqueChar("aabbbbccccdeeeee");
            Assert.AreEqual(result, 10);
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
        public void TestRepeatingChars()
        {
            int result = Text.Str.UniqueChar("aaaaahhh");
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