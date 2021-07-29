using NUnit.Framework;

namespace Tests
{
    ///<summary>Tests adding 2 numbers</summary>
    public class Tests
    {
        [Test]
        public void AdditionPositivesTest()
        {
            int result = MyMath.Operations.Add(2, 4);
            Assert.AreEqual(result, 6);
        }
        
        [Test]
        public void AdditionNegativeTest()
        {
            int result = MyMath.Operations.Add(-2, -1);
            Assert.AreEqual(result, -3);
        }
    }
}
