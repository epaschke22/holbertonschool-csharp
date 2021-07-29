using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestWholeNumbers()
        {
            int[,] input = new int[,] {{2,4,6},{10,12,14}};
            int[,] result = MyMath.Matrix.Divide(input, 2);
            int[,] expected = new int[,] {{1,2,3},{5,6,7}};
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestDividebyZero()
        {
            int[,] input = new int[,] {{2,4,6},{10,12,14}};
            int[,] result = MyMath.Matrix.Divide(input, 0);
            Assert.AreEqual(result, null);
        }

        [Test]
        public void TestEmptyMatrix()
        {
            int[,] result = MyMath.Matrix.Divide(null, 2);
            Assert.AreEqual(result, null);
        }
    }
}
