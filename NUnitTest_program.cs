using NUnit.Framework;
using ConsoleApp1;

namespace TestAny
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(new long[] { }, 1, -1, 0, -1)]
        [TestCase(new long[] {2,4,4,6 },1, -1, 4,-1)]
        [TestCase(new long[] {2,4,4,6 },2, -1, 4,-1)]
        [TestCase(new long[] {2,4,4,6 },3, -1, 4, 0)]
        [TestCase(new long[] {2,4,4,6 },4, -1, 4, 0)]
        [TestCase(new long[] {2,4,4,6 },5, -1, 4, 2)]
        [TestCase(new long[] {2,4,4,6 },6, -1, 4, 2)]
        [TestCase(new long[] {2,4,4,6 },7, -1, 4, 3)]
        public void TestCases(long[] mass, long value, int left, int right, int expect)
        {
            Assert.AreEqual(expect, Example.BinSearchLeftBorder(mass, value, left, right));
        }
    }
}
