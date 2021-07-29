using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestRegular()
        {
            bool result = Text.Str.IsPalindrome("racecar");
            Assert.AreEqual(result, true);
        }

        [Test]
        public void TestSpaces()
        {
            bool result = Text.Str.IsPalindrome("race car");
            Assert.AreEqual(result, true);
        }

        [Test]
        public void TestPunctuation()
        {
            bool result = Text.Str.IsPalindrome("race,car");
            Assert.AreEqual(result, true);
        }

        [Test]
        public void TestCaptial()
        {
            bool result = Text.Str.IsPalindrome("Racecar");
            Assert.AreEqual(result, true);
        }

        [Test]
        public void TestIncorrect()
        {
            bool result = Text.Str.IsPalindrome("Hello");
            Assert.AreEqual(result, false);
        }
    }
}