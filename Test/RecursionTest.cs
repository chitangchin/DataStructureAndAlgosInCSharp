using Exercises;

namespace Test
{
    [TestFixture]
    public class RecursionTest
    {
        [Test]
        public void IterativeTests()
        {
            Assert.That(Recursion.IterativeExponent(2, 2), Is.EqualTo(4));
            Assert.That(Recursion.IterativeExponent(2, 4), Is.EqualTo(16));
        }
        [Test]
        public void RecursiveTests()
        {
            Assert.That(Recursion.RecursiveExponent(2, 2), Is.EqualTo(4));
            Assert.That(Recursion.RecursiveExponent(2, 4), Is.EqualTo(16));
        }
    }
}
